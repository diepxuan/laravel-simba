using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSOND51phhdEdit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("txtDai_dien")]
	private TextBox _txtDai_dien;

	[AccessedThroughProperty("txtCq_thue")]
	private TextBox _txtCq_thue;

	[AccessedThroughProperty("txtMa_thuedvcq")]
	private TextBox _txtMa_thuedvcq;

	[AccessedThroughProperty("txtDonvi_cq")]
	private TextBox _txtDonvi_cq;

	[AccessedThroughProperty("txtTel")]
	private TextBox _txtTel;

	[AccessedThroughProperty("txtDia_chi")]
	private TextBox _txtDia_chi;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtNgay_tb")]
	private AsMaskedTextBox _txtNgay_tb;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtDonvi_ph")]
	private TextBox _txtDonvi_ph;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("adgvHD")]
	private AsInputDGV _adgvHD;

	[AccessedThroughProperty("txtNgay_duyet")]
	private AsMaskedTextBox _txtNgay_duyet;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("txtMa_thue")]
	private TextBox _txtMa_thue;

	[AccessedThroughProperty("txtMa_tb")]
	private TextBox _txtMa_tb;

	[AccessedThroughProperty("dgvcMau_so")]
	private DataGridViewAsTextBoxColumn _dgvcMau_so;

	[AccessedThroughProperty("dgvcMa_loai")]
	private DataGridViewTextBoxColumn _dgvcMa_loai;

	[AccessedThroughProperty("dgvcKy_hieu")]
	private DataGridViewTextBoxColumn _dgvcKy_hieu;

	[AccessedThroughProperty("dgvcSo_hd")]
	private DataGridViewTextBoxColumn _dgvcSo_hd;

	[AccessedThroughProperty("dgvcTu_so")]
	private DataGridViewAsTextNumericColumn _dgvcTu_so;

	[AccessedThroughProperty("dgvcDen_so")]
	private DataGridViewAsTextNumericColumn _dgvcDen_so;

	[AccessedThroughProperty("dgvcSo_luong")]
	private DataGridViewTextBoxColumn _dgvcSo_luong;

	[AccessedThroughProperty("dgvcNgay_sd")]
	private DataGridViewAsMaskedTextBoxColumn _dgvcNgay_sd;

	[AccessedThroughProperty("dgvcTen_dvi")]
	private DataGridViewTextBoxColumn _dgvcTen_dvi;

	[AccessedThroughProperty("dgvcMa_thuedvi")]
	private DataGridViewTextBoxColumn _dgvcMa_thuedvi;

	[AccessedThroughProperty("dgvcNgay_in")]
	private DataGridViewAsMaskedTextBoxColumn _dgvcNgay_in;

	[AccessedThroughProperty("dgvcTen_Loai")]
	private DataGridViewTextBoxColumn _dgvcTen_Loai;

	private DataTable oDthd;

	internal virtual TextBox txtDai_dien
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDai_dien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDai_dien = value;
		}
	}

	internal virtual TextBox txtCq_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCq_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCq_thue = value;
		}
	}

	internal virtual TextBox txtMa_thuedvcq
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_thuedvcq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_thuedvcq = value;
		}
	}

	internal virtual TextBox txtDonvi_cq
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDonvi_cq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDonvi_cq = value;
		}
	}

	internal virtual TextBox txtTel
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyPressEventHandler val = new KeyPressEventHandler(txtMa_tb_KeyPress);
			if (_txtTel != null)
			{
				((Control)_txtTel).KeyPress -= val;
			}
			_txtTel = value;
			if (_txtTel != null)
			{
				((Control)_txtTel).KeyPress += val;
			}
		}
	}

	internal virtual TextBox txtDia_chi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDia_chi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDia_chi = value;
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

	internal virtual AsMaskedTextBox txtNgay_tb
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_tb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_tb = value;
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

	internal virtual TextBox txtDonvi_ph
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDonvi_ph;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDonvi_ph = value;
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

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
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

	internal virtual AsInputDGV adgvHD
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvHD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvHD_CellEndEdit);
			DataGridViewCellValidatingEventHandler val2 = new DataGridViewCellValidatingEventHandler(adgvHD_CellValidating);
			DataGridViewCellEventHandler val3 = new DataGridViewCellEventHandler(adgvHD_CellEnter);
			if (_adgvHD != null)
			{
				((DataGridView)_adgvHD).CellEndEdit -= val;
				((DataGridView)_adgvHD).CellValidating -= val2;
				((DataGridView)_adgvHD).CellEnter -= val3;
			}
			_adgvHD = value;
			if (_adgvHD != null)
			{
				((DataGridView)_adgvHD).CellEndEdit += val;
				((DataGridView)_adgvHD).CellValidating += val2;
				((DataGridView)_adgvHD).CellEnter += val3;
			}
		}
	}

	internal virtual AsMaskedTextBox txtNgay_duyet
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_duyet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_duyet = value;
		}
	}

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual TextBox txtMa_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_thue = value;
		}
	}

	internal virtual TextBox txtMa_tb
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_tb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = txtMa_tb_Leave;
			KeyPressEventHandler val = new KeyPressEventHandler(txtMa_tb_KeyPress);
			if (_txtMa_tb != null)
			{
				((Control)_txtMa_tb).Leave -= eventHandler;
				((Control)_txtMa_tb).KeyPress -= val;
			}
			_txtMa_tb = value;
			if (_txtMa_tb != null)
			{
				((Control)_txtMa_tb).Leave += eventHandler;
				((Control)_txtMa_tb).KeyPress += val;
			}
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMau_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMau_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMau_so = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_loai
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_loai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_loai = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcKy_hieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcKy_hieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcKy_hieu = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcSo_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_hd = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTu_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTu_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTu_so = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcDen_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDen_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDen_so = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcSo_luong
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

	internal virtual DataGridViewAsMaskedTextBoxColumn dgvcNgay_sd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcNgay_sd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcNgay_sd = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_dvi
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_dvi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_dvi = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_thuedvi
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_thuedvi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_thuedvi = value;
		}
	}

	internal virtual DataGridViewAsMaskedTextBoxColumn dgvcNgay_in
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcNgay_in;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcNgay_in = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_Loai
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_Loai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_Loai = value;
		}
	}

	public frmSOND51phhdEdit()
	{
		oDthd = new DataTable();
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
		//IL_001a: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_0eea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef4: Expected O, but got Unknown
		//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff8: Expected O, but got Unknown
		//IL_109c: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a6: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		DataGridViewCellStyle val8 = new DataGridViewCellStyle();
		DataGridViewCellStyle val9 = new DataGridViewCellStyle();
		txtDonvi_ph = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		txtNgay_tb = new AsMaskedTextBox();
		Label4 = new Label();
		txtDia_chi = new TextBox();
		txtTel = new TextBox();
		txtDonvi_cq = new TextBox();
		txtMa_thuedvcq = new TextBox();
		txtCq_thue = new TextBox();
		txtDai_dien = new TextBox();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		Label11 = new Label();
		adgvHD = new AsInputDGV();
		txtNgay_duyet = new AsMaskedTextBox();
		Label12 = new Label();
		txtMa_thue = new TextBox();
		txtMa_tb = new TextBox();
		dgvcMau_so = new DataGridViewAsTextBoxColumn();
		dgvcMa_loai = new DataGridViewTextBoxColumn();
		dgvcKy_hieu = new DataGridViewTextBoxColumn();
		dgvcSo_hd = new DataGridViewTextBoxColumn();
		dgvcTu_so = new DataGridViewAsTextNumericColumn();
		dgvcDen_so = new DataGridViewAsTextNumericColumn();
		dgvcSo_luong = new DataGridViewTextBoxColumn();
		dgvcNgay_sd = new DataGridViewAsMaskedTextBoxColumn();
		dgvcTen_dvi = new DataGridViewTextBoxColumn();
		dgvcMa_thuedvi = new DataGridViewTextBoxColumn();
		dgvcNgay_in = new DataGridViewAsMaskedTextBoxColumn();
		dgvcTen_Loai = new DataGridViewTextBoxColumn();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((ISupportInitialize)adgvHD).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(266, 207);
		((Control)asCheckBox).Location = location;
		AsCheckBox asCheckBox2 = chkKsd;
		Size size = new Size(188, 17);
		((Control)asCheckBox2).Size = size;
		((ButtonBase)chkKsd).Text = "Đã được cơ quan thuế chấp nhận";
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 435);
		((Control)obj).Location = location;
		Button obj2 = cmdSave;
		location = new Point(12, 435);
		((Control)obj2).Location = location;
		((Control)gbLine).Controls.Add((Control)(object)txtMa_tb);
		((Control)gbLine).Controls.Add((Control)(object)adgvHD);
		((Control)gbLine).Controls.Add((Control)(object)Label12);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_duyet);
		((Control)gbLine).Controls.Add((Control)(object)Label11);
		((Control)gbLine).Controls.Add((Control)(object)Label10);
		((Control)gbLine).Controls.Add((Control)(object)Label9);
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)txtDai_dien);
		((Control)gbLine).Controls.Add((Control)(object)txtCq_thue);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_thuedvcq);
		((Control)gbLine).Controls.Add((Control)(object)txtDonvi_cq);
		((Control)gbLine).Controls.Add((Control)(object)txtTel);
		((Control)gbLine).Controls.Add((Control)(object)txtDia_chi);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_tb);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_thue);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)txtDonvi_ph);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		GroupBox obj3 = gbLine;
		size = new Size(665, 423);
		((Control)obj3).Size = size;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDonvi_ph, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_tb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDia_chi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTel, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDonvi_cq, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_thuedvcq, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtCq_thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDai_dien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label9, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label10, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label11, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_duyet, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label12, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)adgvHD, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_tb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		TextBox obj4 = txtDonvi_ph;
		location = new Point(145, 44);
		((Control)obj4).Location = location;
		((Control)txtDonvi_ph).Name = "txtDonvi_ph";
		TextBox obj5 = txtDonvi_ph;
		size = new Size(505, 20);
		((Control)obj5).Size = size;
		((Control)txtDonvi_ph).TabIndex = 102;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(18, 22);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(71, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 102;
		Label1.Text = "Số thông báo";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(18, 48);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(89, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 103;
		Label2.Text = "Đơn vị phát hành";
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(462, 22);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(83, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 104;
		Label3.Text = "Ngày thông báo";
		txtNgay_tb.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_tb).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_tb;
		location = new Point(560, 18);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_tb).Mask = "##/##/####";
		((Control)txtNgay_tb).Name = "txtNgay_tb";
		((MaskedTextBox)txtNgay_tb).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_tb;
		size = new Size(90, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_tb).TabIndex = 101;
		((MaskedTextBox)txtNgay_tb).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_tb;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		Label4.AutoSize = true;
		Label label7 = Label4;
		location = new Point(18, 101);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(114, 13);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 106;
		Label4.Text = "MST đơn vị phát hành";
		TextBox obj6 = txtDia_chi;
		location = new Point(145, 70);
		((Control)obj6).Location = location;
		((Control)txtDia_chi).Name = "txtDia_chi";
		TextBox obj7 = txtDia_chi;
		size = new Size(505, 20);
		((Control)obj7).Size = size;
		((Control)txtDia_chi).TabIndex = 103;
		TextBox obj8 = txtTel;
		location = new Point(314, 97);
		((Control)obj8).Location = location;
		((Control)txtTel).Name = "txtTel";
		TextBox obj9 = txtTel;
		size = new Size(90, 20);
		((Control)obj9).Size = size;
		((Control)txtTel).TabIndex = 105;
		TextBox obj10 = txtDonvi_cq;
		location = new Point(145, 124);
		((Control)obj10).Location = location;
		((Control)txtDonvi_cq).Name = "txtDonvi_cq";
		TextBox obj11 = txtDonvi_cq;
		size = new Size(505, 20);
		((Control)obj11).Size = size;
		((Control)txtDonvi_cq).TabIndex = 107;
		TextBox obj12 = txtMa_thuedvcq;
		location = new Point(145, 151);
		((Control)obj12).Location = location;
		((Control)txtMa_thuedvcq).Name = "txtMa_thuedvcq";
		TextBox obj13 = txtMa_thuedvcq;
		size = new Size(90, 20);
		((Control)obj13).Size = size;
		((Control)txtMa_thuedvcq).TabIndex = 108;
		TextBox obj14 = txtCq_thue;
		location = new Point(145, 178);
		((Control)obj14).Location = location;
		((Control)txtCq_thue).Name = "txtCq_thue";
		TextBox obj15 = txtCq_thue;
		size = new Size(505, 20);
		((Control)obj15).Size = size;
		((Control)txtCq_thue).TabIndex = 109;
		TextBox obj16 = txtDai_dien;
		location = new Point(481, 97);
		((Control)obj16).Location = location;
		((Control)txtDai_dien).Name = "txtDai_dien";
		TextBox obj17 = txtDai_dien;
		size = new Size(169, 20);
		((Control)obj17).Size = size;
		((Control)txtDai_dien).TabIndex = 106;
		Label5.AutoSize = true;
		Label label9 = Label5;
		location = new Point(18, 74);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(40, 13);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 114;
		Label5.Text = "Địa chỉ";
		Label6.AutoSize = true;
		Label label11 = Label6;
		location = new Point(251, 101);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(55, 13);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 115;
		Label6.Text = "Điện thoại";
		Label7.AutoSize = true;
		Label label13 = Label7;
		location = new Point(18, 128);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(86, 13);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 116;
		Label7.Text = "Đơn vị chủ quản";
		Label8.AutoSize = true;
		Label label15 = Label8;
		location = new Point(18, 155);
		((Control)label15).Location = location;
		((Control)Label8).Name = "Label8";
		Label label16 = Label8;
		size = new Size(111, 13);
		((Control)label16).Size = size;
		((Control)Label8).TabIndex = 117;
		Label8.Text = "MST đơn vị chủ quản";
		Label9.AutoSize = true;
		Label label17 = Label9;
		location = new Point(18, 182);
		((Control)label17).Location = location;
		((Control)Label9).Name = "Label9";
		Label label18 = Label9;
		size = new Size(71, 13);
		((Control)label18).Size = size;
		((Control)Label9).TabIndex = 118;
		Label9.Text = "Cơ quan thuế";
		Label10.AutoSize = true;
		Label label19 = Label10;
		location = new Point(429, 101);
		((Control)label19).Location = location;
		((Control)Label10).Name = "Label10";
		Label label20 = Label10;
		size = new Size(46, 13);
		((Control)label20).Size = size;
		((Control)Label10).TabIndex = 119;
		Label10.Text = "Đại diện";
		Label11.AutoSize = true;
		Label label21 = Label11;
		location = new Point(18, 209);
		((Control)label21).Location = location;
		((Control)Label11).Name = "Label11";
		Label label22 = Label11;
		size = new Size(61, 13);
		((Control)label22).Size = size;
		((Control)Label11).TabIndex = 120;
		Label11.Text = "Ngày duyệt";
		((DataGridView)adgvHD).AllowUserToAddRows = false;
		((DataGridView)adgvHD).AllowUserToDeleteRows = false;
		((DataGridView)adgvHD).BackgroundColor = Color.White;
		((DataGridView)adgvHD).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHD).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)adgvHD).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvHD).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[12]
		{
			dgvcMau_so,
			(DataGridViewColumn)dgvcMa_loai,
			(DataGridViewColumn)dgvcKy_hieu,
			(DataGridViewColumn)dgvcSo_hd,
			dgvcTu_so,
			dgvcDen_so,
			(DataGridViewColumn)dgvcSo_luong,
			dgvcNgay_sd,
			(DataGridViewColumn)dgvcTen_dvi,
			(DataGridViewColumn)dgvcMa_thuedvi,
			dgvcNgay_in,
			(DataGridViewColumn)dgvcTen_Loai
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvHD).DefaultCellStyle = val2;
		((DataGridView)adgvHD).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = adgvHD;
		location = new Point(21, 235);
		((Control)asInputDGV).Location = location;
		((DataGridView)adgvHD).MultiSelect = false;
		((Control)adgvHD).Name = "adgvHD";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHD).RowHeadersDefaultCellStyle = val3;
		((DataGridView)adgvHD).RowHeadersVisible = false;
		((DataGridView)adgvHD).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
		((DataGridView)adgvHD).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = adgvHD;
		size = new Size(629, 174);
		((Control)asInputDGV2).Size = size;
		((Control)adgvHD).TabIndex = 123;
		txtNgay_duyet.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_duyet).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_duyet;
		location = new Point(145, 205);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_duyet).Mask = "##/##/####";
		((Control)txtNgay_duyet).Name = "txtNgay_duyet";
		((MaskedTextBox)txtNgay_duyet).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_duyet;
		size = new Size(90, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_duyet).TabIndex = 110;
		((MaskedTextBox)txtNgay_duyet).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_duyet;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		Label12.AutoSize = true;
		Label label23 = Label12;
		location = new Point(495, 209);
		((Control)label23).Location = location;
		((Control)Label12).Name = "Label12";
		Label label24 = Label12;
		size = new Size(155, 13);
		((Control)label24).Size = size;
		((Control)Label12).TabIndex = 124;
		Label12.Text = "F4 - Thêm dòng; F8 - Xoá dòng";
		TextBox obj18 = txtMa_thue;
		location = new Point(145, 97);
		((Control)obj18).Location = location;
		((Control)txtMa_thue).Name = "txtMa_thue";
		TextBox obj19 = txtMa_thue;
		size = new Size(90, 20);
		((Control)obj19).Size = size;
		((Control)txtMa_thue).TabIndex = 104;
		TextBox obj20 = txtMa_tb;
		location = new Point(145, 18);
		((Control)obj20).Location = location;
		((Control)txtMa_tb).Name = "txtMa_tb";
		TextBox obj21 = txtMa_tb;
		size = new Size(90, 20);
		((Control)obj21).Size = size;
		((Control)txtMa_tb).TabIndex = 100;
		dgvcMau_so.AutoFill = true;
		dgvcMau_so.AutoLookup = true;
		dgvcMau_so.AutoValid = true;
		((DataGridViewColumn)dgvcMau_so).DataPropertyName = "MAU_SO";
		val4.BackColor = SystemColors.Info;
		val4.ForeColor = Color.Black;
		((DataGridViewColumn)dgvcMau_so).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcMau_so).HeaderText = "Mẫu Số";
		dgvcMau_so.LookupCodeName = "MAU_SO";
		dgvcMau_so.LookupWhereCondition = "MAU_GOC=0";
		((DataGridViewColumn)dgvcMau_so).Name = "dgvcMau_so";
		dgvcMau_so.ReceiverValidFieldList = "MAU_SO,MA_LOAI,SO_SERI,SO_HD,TEN_LOAI";
		((DataGridViewColumn)dgvcMau_so).Resizable = (DataGridViewTriState)2;
		dgvcMau_so.SD = false;
		dgvcMau_so.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMau_so.ValidReturnFieldList = "MAU_SO,MA_LOAI,SO_SERI,SO_HD,TEN_LOAI";
		((DataGridViewColumn)dgvcMau_so).Width = 80;
		((DataGridViewColumn)dgvcMa_loai).DataPropertyName = "MA_LOAI";
		((DataGridViewColumn)dgvcMa_loai).HeaderText = "Loại HĐ";
		((DataGridViewColumn)dgvcMa_loai).Name = "dgvcMa_loai";
		((DataGridViewColumn)dgvcMa_loai).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_loai).Resizable = (DataGridViewTriState)2;
		dgvcMa_loai.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_loai).Width = 75;
		((DataGridViewColumn)dgvcKy_hieu).DataPropertyName = "SO_SERI";
		((DataGridViewColumn)dgvcKy_hieu).HeaderText = "Ký Hiệu";
		((DataGridViewColumn)dgvcKy_hieu).Name = "dgvcKy_hieu";
		((DataGridViewColumn)dgvcKy_hieu).ReadOnly = true;
		((DataGridViewColumn)dgvcKy_hieu).Resizable = (DataGridViewTriState)2;
		dgvcKy_hieu.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcKy_hieu).Width = 70;
		((DataGridViewColumn)dgvcSo_hd).DataPropertyName = "SO_HD";
		((DataGridViewColumn)dgvcSo_hd).HeaderText = "Số HĐ";
		((DataGridViewColumn)dgvcSo_hd).Name = "dgvcSo_hd";
		((DataGridViewColumn)dgvcSo_hd).ReadOnly = true;
		((DataGridViewColumn)dgvcSo_hd).Resizable = (DataGridViewTriState)2;
		dgvcSo_hd.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcSo_hd).Width = 70;
		((DataGridViewColumn)dgvcTu_so).DataPropertyName = "TU_SO";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "0000000";
		val5.NullValue = "0000000";
		((DataGridViewColumn)dgvcTu_so).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcTu_so).HeaderText = "Từ Số";
		dgvcTu_so.Mask = "0000000";
		((DataGridViewColumn)dgvcTu_so).Name = "dgvcTu_so";
		((DataGridViewColumn)dgvcTu_so).Resizable = (DataGridViewTriState)2;
		dgvcTu_so.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTu_so).Width = 70;
		((DataGridViewColumn)dgvcDen_so).DataPropertyName = "DEN_SO";
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "0000000";
		val6.NullValue = "0000000";
		((DataGridViewColumn)dgvcDen_so).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcDen_so).HeaderText = "Đến Số";
		dgvcDen_so.Mask = "0000000";
		((DataGridViewColumn)dgvcDen_so).Name = "dgvcDen_so";
		((DataGridViewColumn)dgvcDen_so).Resizable = (DataGridViewTriState)2;
		dgvcDen_so.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcDen_so).Width = 70;
		((DataGridViewColumn)dgvcSo_luong).DataPropertyName = "SO_LUONG";
		val7.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)dgvcSo_luong).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcSo_luong).HeaderText = "Số Lượng";
		((DataGridViewColumn)dgvcSo_luong).Name = "dgvcSo_luong";
		((DataGridViewColumn)dgvcSo_luong).ReadOnly = true;
		((DataGridViewColumn)dgvcSo_luong).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)dgvcSo_luong).Width = 80;
		((DataGridViewColumn)dgvcNgay_sd).DataPropertyName = "NGAY_SD";
		val8.Alignment = (DataGridViewContentAlignment)64;
		val8.Format = "dd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_sd).DefaultCellStyle = val8;
		dgvcNgay_sd.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_sd).HeaderText = "Ngày Bắt Đầu SD";
		dgvcNgay_sd.Mask = "##/##/####";
		((DataGridViewColumn)dgvcNgay_sd).Name = "dgvcNgay_sd";
		((DataGridViewColumn)dgvcNgay_sd).Resizable = (DataGridViewTriState)2;
		dgvcNgay_sd.SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcTen_dvi).DataPropertyName = "DONVI_IN";
		((DataGridViewColumn)dgvcTen_dvi).HeaderText = "Tên doanh nghiệp in";
		((DataGridViewColumn)dgvcTen_dvi).Name = "dgvcTen_dvi";
		((DataGridViewColumn)dgvcTen_dvi).Width = 120;
		((DataGridViewColumn)dgvcMa_thuedvi).DataPropertyName = "MA_THUEDVI";
		((DataGridViewColumn)dgvcMa_thuedvi).HeaderText = "MST doanh nghiệp in";
		((DataGridViewColumn)dgvcMa_thuedvi).Name = "dgvcMa_thuedvi";
		((DataGridViewColumn)dgvcMa_thuedvi).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)dgvcMa_thuedvi).Width = 80;
		((DataGridViewColumn)dgvcNgay_in).DataPropertyName = "NGAY_IN";
		val9.Alignment = (DataGridViewContentAlignment)64;
		val9.Format = "dd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_in).DefaultCellStyle = val9;
		dgvcNgay_in.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_in).HeaderText = "Ngày In";
		dgvcNgay_in.Mask = "##/##/####";
		((DataGridViewColumn)dgvcNgay_in).Name = "dgvcNgay_in";
		((DataGridViewColumn)dgvcNgay_in).Resizable = (DataGridViewTriState)2;
		dgvcNgay_in.SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcNgay_in).Width = 80;
		((DataGridViewColumn)dgvcTen_Loai).DataPropertyName = "Ten_Loai";
		((DataGridViewColumn)dgvcTen_Loai).HeaderText = "Loại Hoá Đơn";
		((DataGridViewColumn)dgvcTen_Loai).Name = "dgvcTen_Loai";
		dgvcTen_Loai.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_Loai).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(689, 470);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSOND51phhdEdit";
		((Form)this).Text = "frmSOPHHDEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((ISupportInitialize)adgvHD).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_tb).MaxLength = MyDictComplexInfo.code_length;
		((Control)txtMa_tb).Select();
		GetData(" ");
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			txtNgay_tb.Value = DateTime.Now;
			txtDonvi_ph.Text = CompanyInformations.CompanyName;
			txtDia_chi.Text = CompanyInformations.CompanyAddress;
			txtMa_thue.Text = CompanyInformations.Ma_thue;
			txtTel.Text = CompanyInformations.CompanyTel;
			txtDai_dien.Text = CompanyInformations.Director_Name;
			txtDonvi_cq.Text = CompanyInformations.ParentCompanyName;
			((Control)txtNgay_duyet).Enabled = false;
			((Control)chkKsd).Enabled = false;
			txtMa_tb_Format();
			GetData(" ");
		}
		else
		{
			GetData(txtMa_tb.Text);
			if (Conversions.ToBoolean(chkKsd.Checked))
			{
				((Control)txtNgay_duyet).Enabled = false;
				((Control)chkKsd).Enabled = false;
			}
			else
			{
				((Control)txtNgay_duyet).Enabled = true;
				((Control)chkKsd).Enabled = true;
			}
		}
	}

	protected override bool ValidData()
	{
		if (Operators.CompareString(txtMa_tb.Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtMa_tb, Helper.GetMess(50002).Description);
			((Control)txtMa_tb).Select();
			return false;
		}
		if (Operators.CompareString(((MaskedTextBox)txtNgay_tb).Text.ToString().Replace("/", "").Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtNgay_tb, Helper.GetMess(50002).Description);
			((Control)txtNgay_tb).Select();
			return false;
		}
		if (Operators.CompareString(txtDonvi_ph.Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtDonvi_ph, Helper.GetMess(50002).Description);
			((Control)txtDonvi_ph).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtDia_chi))
		{
			epNotice.SetError((Control)(object)txtDia_chi, Helper.GetMess(50002).Description);
			((Control)txtDia_chi).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtMa_thue))
		{
			epNotice.SetError((Control)(object)txtMa_thue, Helper.GetMess(50002).Description);
			((Control)txtMa_thue).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtTel))
		{
			epNotice.SetError((Control)(object)txtTel, Helper.GetMess(50002).Description);
			((Control)txtTel).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtDai_dien))
		{
			epNotice.SetError((Control)(object)txtDai_dien, Helper.GetMess(50002).Description);
			((Control)txtDai_dien).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtCq_thue))
		{
			epNotice.SetError((Control)(object)txtCq_thue, Helper.GetMess(50002).Description);
			((Control)txtCq_thue).Select();
			return false;
		}
		if (Conversions.ToBoolean((!Conversions.ToBoolean((object)EditMode) || !Conversions.ToBoolean(chkKsd.Checked)) ? ((object)false) : ((object)true)))
		{
			if (Operators.CompareString(((MaskedTextBox)txtNgay_duyet).Text.ToString().Replace("/", "").Trim(), "", false) == 0)
			{
				epNotice.SetError((Control)(object)txtNgay_duyet, Helper.GetMess(50002).Description);
				((Control)txtNgay_duyet).Select();
				return false;
			}
			if (Operators.CompareString(((MaskedTextBox)txtNgay_duyet).Text, ((MaskedTextBox)txtNgay_tb).Text, false) < 0)
			{
				epNotice.SetError((Control)(object)txtNgay_duyet, Helper.GetMess(50013).Description);
				((Control)txtNgay_duyet).Select();
				return false;
			}
		}
		checked
		{
			int num = ((DataGridView)adgvHD).RowCount - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(((DataGridView)adgvHD)[((DataGridViewColumn)dgvcMau_so).Name, i].Value.ToString(), "", false) == 0)
				{
					((DataGridView)adgvHD)[((DataGridViewColumn)dgvcMau_so).Name, i].ErrorText = Helper.GetMess(50002).Description;
					return false;
				}
				((DataGridView)adgvHD)[((DataGridViewColumn)dgvcMau_so).Name, i].ErrorText = "";
				if (Operators.CompareString(((DataGridView)adgvHD)[((DataGridViewColumn)dgvcTu_so).Name, i].Value.ToString(), "", false) == 0)
				{
					((DataGridView)adgvHD)[((DataGridViewColumn)dgvcTu_so).Name, i].ErrorText = Helper.GetMess(50002).Description;
					return false;
				}
				((DataGridView)adgvHD)[((DataGridViewColumn)dgvcTu_so).Name, i].ErrorText = "";
				if (Operators.CompareString(((DataGridView)adgvHD)[((DataGridViewColumn)dgvcDen_so).Name, i].Value.ToString(), "", false) == 0)
				{
					((DataGridView)adgvHD)[((DataGridViewColumn)dgvcDen_so).Name, i].ErrorText = Helper.GetMess(50002).Description;
					return false;
				}
				((DataGridView)adgvHD)[((DataGridViewColumn)dgvcDen_so).Name, i].ErrorText = "";
				if (Operators.CompareString(((DataGridView)adgvHD)[((DataGridViewColumn)dgvcSo_luong).Name, i].Value.ToString(), "", false) == 0)
				{
					((DataGridView)adgvHD)[((DataGridViewColumn)dgvcSo_luong).Name, i].ErrorText = Helper.GetMess(50002).Description;
					return false;
				}
				((DataGridView)adgvHD)[((DataGridViewColumn)dgvcSo_luong).Name, i].ErrorText = "";
				if (Operators.CompareString(((DataGridView)adgvHD)[((DataGridViewColumn)dgvcNgay_sd).Name, i].Value.ToString(), "", false) == 0)
				{
					((DataGridView)adgvHD)[((DataGridViewColumn)dgvcNgay_sd).Name, i].ErrorText = Helper.GetMess(50002).Description;
					return false;
				}
				((DataGridView)adgvHD)[((DataGridViewColumn)dgvcNgay_sd).Name, i].ErrorText = "";
				if (Operators.CompareString(((DataGridView)adgvHD)[((DataGridViewColumn)dgvcTen_dvi).Name, i].Value.ToString(), "", false) == 0)
				{
					((DataGridView)adgvHD)[((DataGridViewColumn)dgvcTen_dvi).Name, i].ErrorText = Helper.GetMess(50002).Description;
					return false;
				}
				((DataGridView)adgvHD)[((DataGridViewColumn)dgvcTen_dvi).Name, i].ErrorText = "";
				if (Operators.CompareString(((DataGridView)adgvHD)[((DataGridViewColumn)dgvcMa_thuedvi).Name, i].Value.ToString(), "", false) == 0)
				{
					((DataGridView)adgvHD)[((DataGridViewColumn)dgvcMa_thuedvi).Name, i].ErrorText = Helper.GetMess(50002).Description;
					return false;
				}
				((DataGridView)adgvHD)[((DataGridViewColumn)dgvcMa_thuedvi).Name, i].ErrorText = "";
				if (Operators.CompareString(((DataGridView)adgvHD)[((DataGridViewColumn)dgvcNgay_in).Name, i].Value.ToString(), "", false) == 0)
				{
					((DataGridView)adgvHD)[((DataGridViewColumn)dgvcNgay_in).Name, i].ErrorText = Helper.GetMess(50002).Description;
					return false;
				}
				((DataGridView)adgvHD)[((DataGridViewColumn)dgvcNgay_in).Name, i].ErrorText = "";
			}
			return base.ValidData();
		}
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_tb).Enabled = false;
	}

	protected override bool InsertToDB()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (((DataGridView)adgvHD).RowCount == 0)
		{
			CMessageBox.Show(50018);
			return false;
		}
		((Control)txtDonvi_ph).Select();
		bool flag = base.InsertToDB();
		if (flag)
		{
			InsertToCTPHHD();
		}
		else
		{
			((Control)txtMa_tb).Select();
		}
		return flag;
	}

	protected override bool UpdateDB()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (((DataGridView)adgvHD).RowCount == 0)
		{
			CMessageBox.Show(50018);
			return false;
		}
		bool result = base.UpdateDB();
		if (Conversions.ToBoolean(Operators.NotObject(chkKsd.Checked)))
		{
			SOND51phhdDAO sOND51phhdDAO = (SOND51phhdDAO)DAOFactory.CreateDAOInstance("SOND51phhdDAO", "SOND51phhd");
			int num = sOND51phhdDAO.Delete(txtMa_tb.Text);
			sOND51phhdDAO.Destroy();
			InsertToCTPHHD();
		}
		return result;
	}

	protected override void DataBinding()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_tb;
		CreateDataBinding(ref ojb, "ma_tb");
		txtMa_tb = (TextBox)ojb;
		ojb = (Control)(object)txtNgay_tb;
		CreateDataBinding(ref ojb, "ngay_tb", "Value");
		txtNgay_tb = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtDonvi_ph;
		CreateDataBinding(ref ojb, "donvi_ph");
		txtDonvi_ph = (TextBox)ojb;
		ojb = (Control)(object)txtDia_chi;
		CreateDataBinding(ref ojb, "dia_chi");
		txtDia_chi = (TextBox)ojb;
		ojb = (Control)(object)txtMa_thue;
		CreateDataBinding(ref ojb, "ma_thue");
		txtMa_thue = (TextBox)ojb;
		ojb = (Control)(object)txtTel;
		CreateDataBinding(ref ojb, "tel");
		txtTel = (TextBox)ojb;
		ojb = (Control)(object)txtDai_dien;
		CreateDataBinding(ref ojb, "dai_dien");
		txtDai_dien = (TextBox)ojb;
		ojb = (Control)(object)txtDonvi_cq;
		CreateDataBinding(ref ojb, "donvi_cq");
		txtDonvi_cq = (TextBox)ojb;
		ojb = (Control)(object)txtMa_thuedvcq;
		CreateDataBinding(ref ojb, "ma_thuedvcq");
		txtMa_thuedvcq = (TextBox)ojb;
		ojb = (Control)(object)txtCq_thue;
		CreateDataBinding(ref ojb, "cq_thue");
		txtCq_thue = (TextBox)ojb;
		ojb = (Control)(object)txtNgay_duyet;
		CreateDataBinding(ref ojb, "ngay_duyet", "Value");
		txtNgay_duyet = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "chap_nhan", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 27)
		{
			((Form)this).Close();
		}
		if ((int)keyData == 115)
		{
			InsertRow();
		}
		if ((int)keyData == 119)
		{
			if (oDthd == null || oDthd.Rows.Count == 0)
			{
				return ((Form)this).ProcessCmdKey(ref msg, keyData);
			}
			DeleteRow();
		}
		if ((int)keyData == 13)
		{
			int rowCount = ((DataGridView)adgvHD).RowCount;
			if (rowCount > 0 && ((DataGridView)adgvHD)[((DataGridViewColumn)dgvcNgay_in).Name, checked(rowCount - 1)].Selected)
			{
				((Control)cmdSave).Focus();
			}
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void txtMa_tb_KeyPress(object sender, KeyPressEventArgs e)
	{
		int KeyAscii = Strings.Asc(e.KeyChar);
		e.Handled = DigitsFilter(ref KeyAscii);
	}

	private void txtMa_tb_Leave(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		txtMa_tb_Format();
		if (Conversions.ToDouble(txtMa_tb.Text) < 1.0)
		{
			CMessageBox.Show(50157);
			((Control)txtMa_tb).Select();
		}
	}

	private void adgvHD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		if ((e.ColumnIndex == 4) | (e.ColumnIndex == 5))
		{
			string text = ((DataGridView)adgvHD)[e.ColumnIndex, e.RowIndex].Value.ToString();
			for (int i = text.Length; i <= 6; i = checked(i + 1))
			{
				text = "0" + text;
			}
			((DataGridView)adgvHD)[e.ColumnIndex, e.RowIndex].Value = text;
			Calculate(e.RowIndex);
		}
	}

	private void adgvHD_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (!((DataGridView)adgvHD)[e.ColumnIndex, e.RowIndex].ReadOnly)
		{
			((DataGridView)adgvHD).BeginEdit(true);
		}
	}

	private void adgvHD_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			int num = ((DataGridView)adgvHD).RowCount - 1;
			for (int i = 0; i <= num; i++)
			{
				if (i != e.RowIndex && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(((DataGridView)adgvHD)[0, e.RowIndex].Value), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(((DataGridView)adgvHD)[0, e.RowIndex].Value), isNum: false), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(((DataGridView)adgvHD)[0, i].Value), isNum: false), false))
				{
					CMessageBox.ShowWithFormat(50179, RuntimeHelpers.GetObjectValue(((DataGridView)adgvHD)[0, e.RowIndex].Value));
					((DataGridView)adgvHD)[0, e.RowIndex].Value = "";
					((DataGridView)adgvHD)[1, e.RowIndex].Value = "";
					((DataGridView)adgvHD)[2, e.RowIndex].Value = "";
					((DataGridView)adgvHD)[3, e.RowIndex].Value = "";
					break;
				}
			}
		}
	}

	protected void GetData(string ma_tb)
	{
		SOND51phhdDAO sOND51phhdDAO = (SOND51phhdDAO)DAOFactory.CreateDAOInstance("SOND51phhdDAO", "SOND51phhd");
		oDthd = sOND51phhdDAO.GetData(ma_tb);
		((DataGridView)adgvHD).DataSource = oDthd;
		sOND51phhdDAO.Destroy();
	}

	protected void InsertRow()
	{
		DataRow dataRow = oDthd.NewRow();
		dataRow["tu_so"] = "0000000";
		dataRow["den_so"] = "0000000";
		dataRow["so_luong"] = "1";
		dataRow["ngay_sd"] = DateTime.Now;
		dataRow["donvi_in"] = txtDonvi_ph.Text;
		dataRow["ma_thuedvi"] = txtMa_thue.Text;
		dataRow["ngay_in"] = DateTime.Now;
		oDthd.Rows.Add(dataRow);
		((DataGridView)adgvHD).CurrentCell = ((DataGridView)adgvHD)[0, checked(((DataGridView)adgvHD).RowCount - 1)];
		((DataGridView)adgvHD).BeginEdit(true);
	}

	protected void DeleteRow()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		if ((int)CMessageBox.Show(Helper.GetMessContent(50003), SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256) != 7)
		{
			((DataGridView)adgvHD).Rows.RemoveAt(((DataGridViewBand)((DataGridView)adgvHD).CurrentRow).Index);
		}
	}

	protected void InsertToCTPHHD()
	{
		int rowCount = ((DataGridView)adgvHD).RowCount;
		SOND51phhdDAO sOND51phhdDAO = (SOND51phhdDAO)DAOFactory.CreateDAOInstance("SOND51phhdDAO", "SOND51phhd");
		checked
		{
			int num = rowCount - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = sOND51phhdDAO.Insert(txtMa_tb.Text, Conversions.ToString(((DataGridView)adgvHD)[0, i].Value), Conversions.ToString(((DataGridView)adgvHD)[1, i].Value), Conversions.ToString(((DataGridView)adgvHD)[2, i].Value), Conversions.ToString(((DataGridView)adgvHD)[3, i].Value), Conversions.ToString(((DataGridView)adgvHD)[4, i].Value), Conversions.ToString(((DataGridView)adgvHD)[5, i].Value), Conversions.ToString(((DataGridView)adgvHD)[6, i].Value), Conversions.ToDate(((DataGridView)adgvHD)[7, i].Value), Conversions.ToString(((DataGridView)adgvHD)[8, i].Value), Conversions.ToString(((DataGridView)adgvHD)[9, i].Value), Conversions.ToDate(((DataGridView)adgvHD)[10, i].Value), Conversions.ToString(((DataGridView)adgvHD)[11, i].Value));
			}
			sOND51phhdDAO.Destroy();
		}
	}

	protected void txtMa_tb_Format()
	{
		int length = txtMa_tb.Text.Length;
		if (Operators.CompareString(txtMa_tb.Text, "", false) == 0)
		{
			txtMa_tb.Text = "00000000";
			return;
		}
		checked
		{
			int num = MyDictComplexInfo.code_length - length;
			for (int i = 1; i <= num; i++)
			{
				txtMa_tb.Text = "0" + txtMa_tb.Text;
			}
		}
	}

	protected bool DigitsFilter(ref int KeyAscii)
	{
		if (KeyAscii >= 32 && Strings.InStr("0987654321", Conversions.ToString(Strings.Chr(KeyAscii)), (CompareMethod)0) <= 0)
		{
			return true;
		}
		bool result = default(bool);
		return result;
	}

	protected void Calculate(int index)
	{
		int num = Convert.ToInt32(((DataGridView)adgvHD)[((DataGridViewColumn)dgvcTu_so).Name, index].Value.ToString());
		int num2 = Convert.ToInt32(((DataGridView)adgvHD)[((DataGridViewColumn)dgvcDen_so).Name, index].Value.ToString());
		((DataGridView)adgvHD)[((DataGridViewColumn)dgvcSo_luong).Name, index].Value = checked(num2 - num + 1);
	}
}
