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

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCACDPCEdit : frmOBEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblNgayCT")]
	private Label _lblNgayCT;

	[AccessedThroughProperty("txtNgay_ct")]
	private AsMaskedTextBox _txtNgay_ct;

	[AccessedThroughProperty("txtSo_ct")]
	private TextBox _txtSo_ct;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtMa_kh")]
	private AsTextBox _txtMa_kh;

	[AccessedThroughProperty("lblMa_kh")]
	private Label _lblMa_kh;

	[AccessedThroughProperty("txtTk_tu")]
	private AsTextBox _txtTk_tu;

	[AccessedThroughProperty("lblTk_tu")]
	private Label _lblTk_tu;

	[AccessedThroughProperty("txtTien_pc_nt")]
	private AsTextNumeric _txtTien_pc_nt;

	[AccessedThroughProperty("txtTy_Gia")]
	private AsTextNumeric _txtTy_Gia;

	[AccessedThroughProperty("lblTien_pcnt")]
	private Label _lblTien_pcnt;

	[AccessedThroughProperty("lblMa_nt")]
	private Label _lblMa_nt;

	[AccessedThroughProperty("txtTien_pc")]
	private AsTextNumeric _txtTien_pc;

	[AccessedThroughProperty("lblTien_PC")]
	private Label _lblTien_PC;

	[AccessedThroughProperty("txtDien_giai")]
	private TextBox _txtDien_giai;

	[AccessedThroughProperty("txtDa_tt")]
	private AsTextNumeric _txtDa_tt;

	[AccessedThroughProperty("txtDa_tt_nt")]
	private AsTextNumeric _txtDa_tt_nt;

	[AccessedThroughProperty("lblDA_TT")]
	private Label _lblDA_TT;

	[AccessedThroughProperty("lblDienGiai")]
	private Label _lblDienGiai;

	[AccessedThroughProperty("lblDa_TT_nt")]
	private Label _lblDa_TT_nt;

	[AccessedThroughProperty("lblNgayTT")]
	private Label _lblNgayTT;

	[AccessedThroughProperty("txtNgay_ct_tt")]
	private AsMaskedTextBox _txtNgay_ct_tt;

	[AccessedThroughProperty("cboNt")]
	private AsComboBoxNT _cboNt;

	[AccessedThroughProperty("lblTen_KH")]
	private Label _lblTen_KH;

	[AccessedThroughProperty("lblTen_tk")]
	private Label _lblTen_tk;

	[AccessedThroughProperty("txtSo_du_nt")]
	private AsTextNumeric _txtSo_du_nt;

	[AccessedThroughProperty("lblSo_du")]
	private Label _lblSo_du;

	[AccessedThroughProperty("txtSo_du")]
	private AsTextNumeric _txtSo_du;

	[AccessedThroughProperty("lblSo_du_nt")]
	private Label _lblSo_du_nt;

	[AccessedThroughProperty("txtSo_ct_tt")]
	private TextBox _txtSo_ct_tt;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("chk_TT")]
	private CheckBox _chk_TT;

	private const string sTien_PC = "Tiền PC";

	private const string sDa_TT = "Đã TT";

	private const string sSo_DU = "Số dư";

	internal virtual Label lblNgayCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgayCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgayCT = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_ct = value;
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

	internal virtual AsTextBox txtMa_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_kh = value;
		}
	}

	internal virtual Label lblMa_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_kh = value;
		}
	}

	internal virtual AsTextBox txtTk_tu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_tu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_tu = value;
		}
	}

	internal virtual Label lblTk_tu
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_tu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_tu = value;
		}
	}

	internal virtual AsTextNumeric txtTien_pc_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien_pc_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtTien_PC_nt_Validated;
			if (_txtTien_pc_nt != null)
			{
				((Control)_txtTien_pc_nt).Validated -= eventHandler;
			}
			_txtTien_pc_nt = value;
			if (_txtTien_pc_nt != null)
			{
				((Control)_txtTien_pc_nt).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtTy_Gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTy_Gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtTyGia_Validated;
			if (_txtTy_Gia != null)
			{
				((Control)_txtTy_Gia).Validated -= eventHandler;
			}
			_txtTy_Gia = value;
			if (_txtTy_Gia != null)
			{
				((Control)_txtTy_Gia).Validated += eventHandler;
			}
		}
	}

	internal virtual Label lblTien_pcnt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTien_pcnt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTien_pcnt = value;
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

	internal virtual AsTextNumeric txtTien_pc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien_pc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtTien_pc_Validated;
			if (_txtTien_pc != null)
			{
				((Control)_txtTien_pc).Validated -= eventHandler;
			}
			_txtTien_pc = value;
			if (_txtTien_pc != null)
			{
				((Control)_txtTien_pc).Validated += eventHandler;
			}
		}
	}

	internal virtual Label lblTien_PC
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTien_PC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTien_PC = value;
		}
	}

	internal virtual TextBox txtDien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDien_giai = value;
		}
	}

	internal virtual AsTextNumeric txtDa_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDa_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtda_tt_Validated;
			if (_txtDa_tt != null)
			{
				((Control)_txtDa_tt).Validated -= eventHandler;
			}
			_txtDa_tt = value;
			if (_txtDa_tt != null)
			{
				((Control)_txtDa_tt).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtDa_tt_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDa_tt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txt_da_tt_nt_Validated;
			if (_txtDa_tt_nt != null)
			{
				((Control)_txtDa_tt_nt).Validated -= eventHandler;
			}
			_txtDa_tt_nt = value;
			if (_txtDa_tt_nt != null)
			{
				((Control)_txtDa_tt_nt).Validated += eventHandler;
			}
		}
	}

	internal virtual Label lblDA_TT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDA_TT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDA_TT = value;
		}
	}

	internal virtual Label lblDienGiai
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDienGiai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDienGiai = value;
		}
	}

	internal virtual Label lblDa_TT_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDa_TT_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDa_TT_nt = value;
		}
	}

	internal virtual Label lblNgayTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgayTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgayTT = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_ct_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_ct_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_ct_tt = value;
		}
	}

	internal virtual AsComboBoxNT cboNt
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboNt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboNt_SelectedValueChanged;
			if (_cboNt != null)
			{
				((ListControl)_cboNt).SelectedValueChanged -= eventHandler;
			}
			_cboNt = value;
			if (_cboNt != null)
			{
				((ListControl)_cboNt).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblTen_KH
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_KH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_KH = value;
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

	internal virtual AsTextNumeric txtSo_du_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_du_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtSo_du_nt_TextChanged;
			if (_txtSo_du_nt != null)
			{
				((Control)_txtSo_du_nt).TextChanged -= eventHandler;
			}
			_txtSo_du_nt = value;
			if (_txtSo_du_nt != null)
			{
				((Control)_txtSo_du_nt).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblSo_du
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_du = value;
		}
	}

	internal virtual AsTextNumeric txtSo_du
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_du = value;
		}
	}

	internal virtual Label lblSo_du_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_du_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_du_nt = value;
		}
	}

	internal virtual TextBox txtSo_ct_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_ct_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_ct_tt = value;
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

	internal virtual CheckBox chk_TT
	{
		[DebuggerNonUserCode]
		get
		{
			return _chk_TT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chk_TT = value;
		}
	}

	[DebuggerNonUserCode]
	public frmCACDPCEdit()
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		lblNgayCT = new Label();
		txtNgay_ct = new AsMaskedTextBox();
		txtSo_ct = new TextBox();
		Label1 = new Label();
		lblMa_kh = new Label();
		txtMa_kh = new AsTextBox();
		lblTen_KH = new Label();
		lblTk_tu = new Label();
		txtTk_tu = new AsTextBox();
		lblTen_tk = new Label();
		cboNt = new AsComboBoxNT();
		txtTy_Gia = new AsTextNumeric();
		lblMa_nt = new Label();
		lblTien_pcnt = new Label();
		txtTien_pc_nt = new AsTextNumeric();
		lblTien_PC = new Label();
		txtTien_pc = new AsTextNumeric();
		txtNgay_ct_tt = new AsMaskedTextBox();
		lblNgayTT = new Label();
		lblDa_TT_nt = new Label();
		lblDA_TT = new Label();
		txtDa_tt_nt = new AsTextNumeric();
		txtDa_tt = new AsTextNumeric();
		txtDien_giai = new TextBox();
		lblDienGiai = new Label();
		txtSo_du_nt = new AsTextNumeric();
		lblSo_du = new Label();
		txtSo_du = new AsTextNumeric();
		lblSo_du_nt = new Label();
		txtSo_ct_tt = new TextBox();
		Label4 = new Label();
		chk_TT = new CheckBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(248, 344);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 261);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 261);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)chk_TT);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct_tt);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_du_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_du);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_du);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_du_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtDa_tt_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbLine).Controls.Add((Control)(object)txtTien_pc_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtTy_Gia);
		((Control)gbLine).Controls.Add((Control)(object)lblDa_TT_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblDienGiai);
		((Control)gbLine).Controls.Add((Control)(object)cboNt);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_tu);
		((Control)gbLine).Controls.Add((Control)(object)lblTien_pcnt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_tu);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_kh);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_kh);
		((Control)gbLine).Controls.Add((Control)(object)lblNgayCT);
		((Control)gbLine).Controls.Add((Control)(object)lblNgayTT);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_ct_tt);
		((Control)gbLine).Controls.Add((Control)(object)txtDa_tt);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_KH);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tk);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtTien_pc);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)lblDA_TT);
		((Control)gbLine).Controls.Add((Control)(object)lblTien_PC);
		GroupBox obj3 = gbLine;
		Size size = new Size(527, 249);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTien_PC, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDA_TT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTien_pc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_KH, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDa_tt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_ct_tt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgayTT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgayCT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_tu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTien_pcnt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_tu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboNt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDienGiai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDa_TT_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTy_Gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTien_pc_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDien_giai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDa_tt_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_du_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_du, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_du, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_du_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct_tt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chk_TT, 0);
		lblNgayCT.AutoSize = true;
		Label obj4 = lblNgayCT;
		location = new Point(18, 22);
		((Control)obj4).Location = location;
		((Control)lblNgayCT).Name = "lblNgayCT";
		Label obj5 = lblNgayCT;
		size = new Size(78, 13);
		((Control)obj5).Size = size;
		((Control)lblNgayCT).TabIndex = 100;
		lblNgayCT.Text = "Ngày phiếu chi";
		txtNgay_ct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ct;
		location = new Point(130, 19);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_ct).Mask = "##/##/####";
		((Control)txtNgay_ct).Name = "txtNgay_ct";
		((MaskedTextBox)txtNgay_ct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_ct;
		size = new Size(77, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_ct).TabIndex = 0;
		((MaskedTextBox)txtNgay_ct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_ct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		TextBox obj6 = txtSo_ct;
		location = new Point(406, 18);
		((Control)obj6).Location = location;
		((Control)txtSo_ct).Name = "txtSo_ct";
		TextBox obj7 = txtSo_ct;
		size = new Size(101, 20);
		((Control)obj7).Size = size;
		((Control)txtSo_ct).TabIndex = 1;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(312, 22);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(66, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 100;
		Label1.Text = "Số phiếu chi";
		lblMa_kh.AutoSize = true;
		Label obj8 = lblMa_kh;
		location = new Point(18, 72);
		((Control)obj8).Location = location;
		((Control)lblMa_kh).Name = "lblMa_kh";
		Label obj9 = lblMa_kh;
		size = new Size(40, 13);
		((Control)obj9).Size = size;
		((Control)lblMa_kh).TabIndex = 103;
		lblMa_kh.Text = "Mã KH";
		txtMa_kh.AutoLookup = true;
		txtMa_kh.AutoValid = true;
		((TextBoxBase)txtMa_kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_kh;
		location = new Point(130, 69);
		((Control)asTextBox).Location = location;
		txtMa_kh.LookupCodeName = "MA_KH";
		((Control)txtMa_kh).Name = "txtMa_kh";
		txtMa_kh.NameControl = lblTen_KH;
		AsTextBox asTextBox2 = txtMa_kh;
		size = new Size(77, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_kh).TabIndex = 4;
		txtMa_kh.UseAutoCompleteSource = true;
		txtMa_kh.ValidReturnFieldList = "MA_KH,TEN_KH";
		Label obj10 = lblTen_KH;
		location = new Point(213, 73);
		((Control)obj10).Location = location;
		((Control)lblTen_KH).Name = "lblTen_KH";
		Label obj11 = lblTen_KH;
		size = new Size(197, 13);
		((Control)obj11).Size = size;
		((Control)lblTen_KH).TabIndex = 100;
		lblTk_tu.AutoSize = true;
		Label obj12 = lblTk_tu;
		location = new Point(18, 97);
		((Control)obj12).Location = location;
		((Control)lblTk_tu).Name = "lblTk_tu";
		Label obj13 = lblTk_tu;
		size = new Size(62, 13);
		((Control)obj13).Size = size;
		((Control)lblTk_tu).TabIndex = 103;
		lblTk_tu.Text = "TK tạm ứng";
		txtTk_tu.AutoLookup = true;
		txtTk_tu.AutoValid = true;
		((TextBoxBase)txtTk_tu).BackColor = SystemColors.Info;
		((TextBox)txtTk_tu).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTk_tu;
		location = new Point(130, 94);
		((Control)asTextBox3).Location = location;
		txtTk_tu.LookupCodeName = "TK";
		((Control)txtTk_tu).Name = "txtTk_tu";
		txtTk_tu.NameControl = lblTen_tk;
		AsTextBox asTextBox4 = txtTk_tu;
		size = new Size(77, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTk_tu).TabIndex = 5;
		txtTk_tu.UseAutoCompleteSource = true;
		txtTk_tu.ValidReturnFieldList = "TK,TEN_TK";
		Label obj14 = lblTen_tk;
		location = new Point(213, 98);
		((Control)obj14).Location = location;
		((Control)lblTen_tk).Name = "lblTen_tk";
		Label obj15 = lblTen_tk;
		size = new Size(197, 13);
		((Control)obj15).Size = size;
		((Control)lblTen_tk).TabIndex = 100;
		((ComboBox)cboNt).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNt).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboNt;
		location = new Point(130, 119);
		((Control)asComboBoxNT).Location = location;
		cboNt.MA_NT = "";
		((Control)cboNt).Name = "cboNt";
		AsComboBoxNT asComboBoxNT2 = cboNt;
		size = new Size(61, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboNt).TabIndex = 6;
		txtTy_Gia.DecimalSymbol = ".";
		txtTy_Gia.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtTy_Gia;
		location = new Point(194, 119);
		((Control)asTextNumeric).Location = location;
		txtTy_Gia.Mask = "### ### ### ###.##";
		((Control)txtTy_Gia).Name = "txtTy_Gia";
		AsTextNumeric asTextNumeric2 = txtTy_Gia;
		size = new Size(54, 20);
		((Control)asTextNumeric2).Size = size;
		txtTy_Gia.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTy_Gia).TabIndex = 7;
		((TextBox)txtTy_Gia).Text = "0.00";
		((TextBox)txtTy_Gia).TextAlign = (HorizontalAlignment)1;
		txtTy_Gia.Value = 0;
		lblMa_nt.AutoSize = true;
		Label obj16 = lblMa_nt;
		location = new Point(18, 122);
		((Control)obj16).Location = location;
		((Control)lblMa_nt).Name = "lblMa_nt";
		Label obj17 = lblMa_nt;
		size = new Size(40, 13);
		((Control)obj17).Size = size;
		((Control)lblMa_nt).TabIndex = 103;
		lblMa_nt.Text = "Mã NT";
		lblTien_pcnt.AutoSize = true;
		Label obj18 = lblTien_pcnt;
		location = new Point(18, 148);
		((Control)obj18).Location = location;
		((Control)lblTien_pcnt).Name = "lblTien_pcnt";
		Label obj19 = lblTien_pcnt;
		size = new Size(63, 13);
		((Control)obj19).Size = size;
		((Control)lblTien_pcnt).TabIndex = 103;
		lblTien_pcnt.Text = "Tiền PC NT";
		txtTien_pc_nt.DecimalSymbol = ".";
		txtTien_pc_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtTien_pc_nt;
		location = new Point(130, 145);
		((Control)asTextNumeric3).Location = location;
		txtTien_pc_nt.Mask = "### ### ### ###.##";
		((Control)txtTien_pc_nt).Name = "txtTien_pc_nt";
		AsTextNumeric asTextNumeric4 = txtTien_pc_nt;
		size = new Size(118, 20);
		((Control)asTextNumeric4).Size = size;
		txtTien_pc_nt.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTien_pc_nt).TabIndex = 8;
		((Control)txtTien_pc_nt).Tag = "FA";
		((TextBox)txtTien_pc_nt).Text = "0.00";
		((TextBox)txtTien_pc_nt).TextAlign = (HorizontalAlignment)1;
		txtTien_pc_nt.Value = 0;
		lblTien_PC.AutoSize = true;
		Label obj20 = lblTien_PC;
		location = new Point(312, 148);
		((Control)obj20).Location = location;
		((Control)lblTien_PC).Name = "lblTien_PC";
		Label obj21 = lblTien_PC;
		size = new Size(45, 13);
		((Control)obj21).Size = size;
		((Control)lblTien_PC).TabIndex = 103;
		lblTien_PC.Text = "Tiền PC";
		txtTien_pc.DecimalSymbol = ".";
		txtTien_pc.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtTien_pc;
		location = new Point(406, 144);
		((Control)asTextNumeric5).Location = location;
		txtTien_pc.Mask = "### ### ### ###.##";
		((Control)txtTien_pc).Name = "txtTien_pc";
		AsTextNumeric asTextNumeric6 = txtTien_pc;
		size = new Size(101, 20);
		((Control)asTextNumeric6).Size = size;
		txtTien_pc.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTien_pc).TabIndex = 9;
		((Control)txtTien_pc).Tag = "OA";
		((TextBox)txtTien_pc).Text = "0.00";
		((TextBox)txtTien_pc).TextAlign = (HorizontalAlignment)1;
		txtTien_pc.Value = 0;
		txtNgay_ct_tt.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct_tt).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_ct_tt;
		location = new Point(130, 44);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_ct_tt).Mask = "##/##/####";
		((Control)txtNgay_ct_tt).Name = "txtNgay_ct_tt";
		((MaskedTextBox)txtNgay_ct_tt).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_ct_tt;
		size = new Size(77, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_ct_tt).TabIndex = 2;
		((MaskedTextBox)txtNgay_ct_tt).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_ct_tt;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		lblNgayTT.AutoSize = true;
		Label obj22 = lblNgayTT;
		location = new Point(18, 47);
		((Control)obj22).Location = location;
		((Control)lblNgayTT).Name = "lblNgayTT";
		Label obj23 = lblNgayTT;
		size = new Size(86, 13);
		((Control)obj23).Size = size;
		((Control)lblNgayTT).TabIndex = 100;
		lblNgayTT.Text = "Ngày thanh toán";
		lblDa_TT_nt.AutoSize = true;
		Label obj24 = lblDa_TT_nt;
		location = new Point(18, 173);
		((Control)obj24).Location = location;
		((Control)lblDa_TT_nt).Name = "lblDa_TT_nt";
		Label obj25 = lblDa_TT_nt;
		size = new Size(56, 13);
		((Control)obj25).Size = size;
		((Control)lblDa_TT_nt).TabIndex = 103;
		lblDa_TT_nt.Text = "Đã TT NT";
		lblDA_TT.AutoSize = true;
		Label obj26 = lblDA_TT;
		location = new Point(312, 173);
		((Control)obj26).Location = location;
		((Control)lblDA_TT).Name = "lblDA_TT";
		Label obj27 = lblDA_TT;
		size = new Size(38, 13);
		((Control)obj27).Size = size;
		((Control)lblDA_TT).TabIndex = 103;
		lblDA_TT.Text = "Đã TT";
		txtDa_tt_nt.DecimalSymbol = ".";
		txtDa_tt_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtDa_tt_nt;
		location = new Point(130, 170);
		((Control)asTextNumeric7).Location = location;
		txtDa_tt_nt.Mask = "### ### ### ###.##";
		((Control)txtDa_tt_nt).Name = "txtDa_tt_nt";
		AsTextNumeric asTextNumeric8 = txtDa_tt_nt;
		size = new Size(118, 20);
		((Control)asTextNumeric8).Size = size;
		txtDa_tt_nt.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtDa_tt_nt).TabIndex = 10;
		((Control)txtDa_tt_nt).Tag = "FA";
		((TextBox)txtDa_tt_nt).Text = "0.00";
		((TextBox)txtDa_tt_nt).TextAlign = (HorizontalAlignment)1;
		txtDa_tt_nt.Value = 0;
		txtDa_tt.DecimalSymbol = ".";
		txtDa_tt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric9 = txtDa_tt;
		location = new Point(406, 169);
		((Control)asTextNumeric9).Location = location;
		txtDa_tt.Mask = "### ### ### ###.##";
		((Control)txtDa_tt).Name = "txtDa_tt";
		AsTextNumeric asTextNumeric10 = txtDa_tt;
		size = new Size(101, 20);
		((Control)asTextNumeric10).Size = size;
		txtDa_tt.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtDa_tt).TabIndex = 11;
		((Control)txtDa_tt).Tag = "OA";
		((TextBox)txtDa_tt).Text = "0.00";
		((TextBox)txtDa_tt).TextAlign = (HorizontalAlignment)1;
		txtDa_tt.Value = 0;
		TextBox obj28 = txtDien_giai;
		location = new Point(130, 220);
		((Control)obj28).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj29 = txtDien_giai;
		size = new Size(377, 20);
		((Control)obj29).Size = size;
		((Control)txtDien_giai).TabIndex = 14;
		lblDienGiai.AutoSize = true;
		Label obj30 = lblDienGiai;
		location = new Point(18, 224);
		((Control)obj30).Location = location;
		((Control)lblDienGiai).Name = "lblDienGiai";
		Label obj31 = lblDienGiai;
		size = new Size(48, 13);
		((Control)obj31).Size = size;
		((Control)lblDienGiai).TabIndex = 103;
		lblDienGiai.Text = "Diễn giải";
		txtSo_du_nt.DecimalSymbol = ".";
		((Control)txtSo_du_nt).Enabled = false;
		txtSo_du_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric11 = txtSo_du_nt;
		location = new Point(130, 196);
		((Control)asTextNumeric11).Location = location;
		txtSo_du_nt.Mask = "### ### ### ###.##";
		((Control)txtSo_du_nt).Name = "txtSo_du_nt";
		AsTextNumeric asTextNumeric12 = txtSo_du_nt;
		size = new Size(118, 20);
		((Control)asTextNumeric12).Size = size;
		txtSo_du_nt.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSo_du_nt).TabIndex = 12;
		((Control)txtSo_du_nt).Tag = "FA";
		((TextBox)txtSo_du_nt).Text = "0.00";
		((TextBox)txtSo_du_nt).TextAlign = (HorizontalAlignment)1;
		txtSo_du_nt.Value = 0;
		lblSo_du.AutoSize = true;
		Label obj32 = lblSo_du;
		location = new Point(312, 198);
		((Control)obj32).Location = location;
		((Control)lblSo_du).Name = "lblSo_du";
		Label obj33 = lblSo_du;
		size = new Size(35, 13);
		((Control)obj33).Size = size;
		((Control)lblSo_du).TabIndex = 107;
		lblSo_du.Text = "Số dư";
		txtSo_du.DecimalSymbol = ".";
		((Control)txtSo_du).Enabled = false;
		txtSo_du.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric13 = txtSo_du;
		location = new Point(406, 195);
		((Control)asTextNumeric13).Location = location;
		txtSo_du.Mask = "### ### ### ###.##";
		((Control)txtSo_du).Name = "txtSo_du";
		AsTextNumeric asTextNumeric14 = txtSo_du;
		size = new Size(101, 20);
		((Control)asTextNumeric14).Size = size;
		txtSo_du.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSo_du).TabIndex = 13;
		((Control)txtSo_du).Tag = "OA";
		((TextBox)txtSo_du).Text = "0.00";
		((TextBox)txtSo_du).TextAlign = (HorizontalAlignment)1;
		txtSo_du.Value = 0;
		lblSo_du_nt.AutoSize = true;
		Label obj34 = lblSo_du_nt;
		location = new Point(18, 198);
		((Control)obj34).Location = location;
		((Control)lblSo_du_nt).Name = "lblSo_du_nt";
		Label obj35 = lblSo_du_nt;
		size = new Size(53, 13);
		((Control)obj35).Size = size;
		((Control)lblSo_du_nt).TabIndex = 106;
		lblSo_du_nt.Text = "Số dư NT";
		TextBox obj36 = txtSo_ct_tt;
		location = new Point(406, 43);
		((Control)obj36).Location = location;
		((Control)txtSo_ct_tt).Name = "txtSo_ct_tt";
		TextBox obj37 = txtSo_ct_tt;
		size = new Size(101, 20);
		((Control)obj37).Size = size;
		((Control)txtSo_ct_tt).TabIndex = 3;
		Label4.AutoSize = true;
		Label label3 = Label4;
		location = new Point(312, 47);
		((Control)label3).Location = location;
		((Control)Label4).Name = "Label4";
		Label label4 = Label4;
		size = new Size(82, 13);
		((Control)label4).Size = size;
		((Control)Label4).TabIndex = 109;
		Label4.Text = "Số chứng từ TT";
		((ButtonBase)chk_TT).AutoSize = true;
		((Control)chk_TT).Enabled = false;
		CheckBox obj38 = chk_TT;
		location = new Point(406, 122);
		((Control)obj38).Location = location;
		((Control)chk_TT).Name = "chk_TT";
		CheckBox obj39 = chk_TT;
		size = new Size(66, 17);
		((Control)obj39).Size = size;
		((Control)chk_TT).TabIndex = 110;
		((ButtonBase)chk_TT).Text = "Tất toán";
		((ButtonBase)chk_TT).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(551, 296);
		((Form)this).ClientSize = size;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmCACDPCEdit";
		((Form)this).Text = "Số dư đầu kỳ phiếu chi";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		MaskTextBoxAll(((Control)gbLine).Controls);
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			txtNgay_ct.Value = DateAndTime.Now;
			txtNgay_ct_tt.Value = DateAndTime.Now;
		}
		RefreshControls();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtDien_giai;
		CreateDataBinding(ref ojb, "dien_giai");
		txtDien_giai = (TextBox)ojb;
		ojb = (Control)(object)txtMa_kh;
		CreateDataBinding(ref ojb, "ma_kh");
		txtMa_kh = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_KH;
		CreateDataBinding(ref ojb, "ten_kh");
		lblTen_KH = (Label)ojb;
		ojb = (Control)(object)txtNgay_ct;
		CreateDataBinding(ref ojb, "ngay_ct", "value");
		txtNgay_ct = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_ct_tt;
		CreateDataBinding(ref ojb, "ngay_ct_tt", "value");
		txtNgay_ct_tt = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_ct;
		CreateDataBinding(ref ojb, "so_ct");
		txtSo_ct = (TextBox)ojb;
		ojb = (Control)(object)txtSo_ct_tt;
		CreateDataBinding(ref ojb, "so_ct_tt");
		txtSo_ct_tt = (TextBox)ojb;
		ojb = (Control)(object)txtTien_pc;
		CreateDataBinding(ref ojb, "tien_pc", "value");
		txtTien_pc = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien_pc_nt;
		CreateDataBinding(ref ojb, "tien_pc_nt", "value");
		txtTien_pc_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDa_tt;
		CreateDataBinding(ref ojb, "tien_da_tt", "value");
		txtDa_tt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDa_tt_nt;
		CreateDataBinding(ref ojb, "tien_da_tt_nt", "value");
		txtDa_tt_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)chk_TT;
		CreateDataBinding(ref ojb, "tat_toan", "Checked");
		chk_TT = (CheckBox)ojb;
		ojb = (Control)(object)txtTk_tu;
		CreateDataBinding(ref ojb, "tk_tu");
		txtTk_tu = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_du;
		CreateDataBinding(ref ojb, "so_du", "value");
		txtSo_du = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtSo_du_nt;
		CreateDataBinding(ref ojb, "so_du_nt", "value");
		txtSo_du_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTy_Gia;
		CreateDataBinding(ref ojb, "ty_gia", "value");
		txtTy_Gia = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)cboNt;
		CreateDataBinding(ref ojb, "ma_nt", "SelectedValue");
		cboNt = (AsComboBoxNT)(object)ojb;
	}

	protected override bool ValidData()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectLessEqual(txtNgay_ct.Value, (object)AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks, false))
		{
			CMessageBox.Show(50136);
			return false;
		}
		if (!CanhBaoDieuChinh())
		{
			return false;
		}
		if (Operators.CompareString(cboNt.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			txtTien_PC_nt_Validated(null, null);
			txt_da_tt_nt_Validated(null, null);
			TinhSoDu_Nt();
			TinhSoDu();
		}
		if (Operators.CompareString(txtSo_ct.Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtSo_ct, Helper.GetMess(50002).Description);
			((Control)txtSo_ct).Select();
			return false;
		}
		if (Operators.CompareString(((TextBox)txtMa_kh).Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtMa_kh, Helper.GetMess(50002).Description);
			((Control)txtMa_kh).Select();
			return false;
		}
		if (Operators.CompareString(((TextBox)txtTk_tu).Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtTk_tu, Helper.GetMess(50002).Description);
			((Control)txtTk_tu).Select();
			return false;
		}
		return base.ValidData();
	}

	protected override bool SetToRow()
	{
		base.SetToRow();
		if (!EditMode)
		{
			RowToEdit["stt_rec"] = Commons.Get_SttRec(base.MyMenuInfo.par1);
			RowToEdit["ma_ct"] = base.MyMenuInfo.par1;
			RowToEdit["stt_rec_tt"] = Commons.Get_SttRec(base.MyMenuInfo.par2);
			RowToEdit["ma_ct_tt"] = base.MyMenuInfo.par2;
		}
		bool result = default(bool);
		return result;
	}

	private void txtTyGia_Validated(object sender, EventArgs e)
	{
		txtTien_PC_nt_Validated(RuntimeHelpers.GetObjectValue(sender), e);
		txt_da_tt_nt_Validated(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void MaskTextBoxAll(ControlCollection ctl)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		foreach (Control item in ctl)
		{
			Control val = item;
			if (val is AsTextNumeric)
			{
				AsTextNumeric asTextNumeric = (AsTextNumeric)(object)val;
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"OP", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Price_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FP", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCPrice_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"OA", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FA", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"QT", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Qty_Input_Format;
				}
			}
		}
	}

	private void cboNt_SelectedValueChanged(object sender, EventArgs e)
	{
		RefreshControls();
	}

	private void RefreshControls()
	{
		if (Operators.CompareString(cboNt.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			txtTy_Gia.Value = 1;
			((TextBoxBase)txtTy_Gia).ReadOnly = true;
			lblTien_pcnt.Text = "Tiền PC";
			lblDa_TT_nt.Text = "Đã TT";
			lblSo_du_nt.Text = "Số dư";
			txtTien_pc_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
			txtDa_tt_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
			txtSo_du_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
			((Control)txtTien_pc).Visible = false;
			((Control)txtDa_tt).Visible = false;
			((Control)txtSo_du).Visible = false;
			((Control)lblTien_PC).Visible = false;
			((Control)lblDA_TT).Visible = false;
			((Control)lblSo_du).Visible = false;
		}
		else
		{
			if (!EditMode)
			{
				txtTy_Gia.Value = Commons.Get_TyGia(cboNt.MA_NT, Conversions.ToDate(txtNgay_ct.Value));
			}
			((TextBoxBase)txtTy_Gia).ReadOnly = false;
			lblTien_pcnt.Text = "Tiền PC " + cboNt.MA_NT;
			lblDa_TT_nt.Text = "Đã TT " + cboNt.MA_NT;
			lblSo_du_nt.Text = "Số dư " + cboNt.MA_NT;
			txtTien_pc_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
			txtDa_tt_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
			txtSo_du_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
			((Control)txtTien_pc).Visible = true;
			((Control)txtDa_tt).Visible = true;
			((Control)txtSo_du).Visible = true;
			((Control)lblTien_PC).Visible = true;
			((Control)lblDA_TT).Visible = true;
			((Control)lblSo_du).Visible = true;
		}
		txtTien_PC_nt_Validated(null, null);
		txt_da_tt_nt_Validated(null, null);
		TinhSoDu_Nt();
		TinhSoDu();
	}

	private void GetTyGia()
	{
		txtTy_Gia.Value = Commons.Get_TyGia(cboNt.MA_NT, Conversions.ToDate(txtNgay_ct.Value));
		if ((Operators.CompareString(((ComboBox)cboNt).Text, "VND", false) == 0 && Operators.ConditionalCompareObjectEqual(txtTy_Gia.Value, (object)0, false)) ? true : false)
		{
			txtTy_Gia.Value = 1;
		}
		bool enabled = Operators.CompareString(AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, ((ComboBox)cboNt).Text, false) != 0;
		((Control)txtTy_Gia).Enabled = enabled;
		((Control)txtTien_pc_nt).Enabled = enabled;
		((Control)txtDa_tt_nt).Enabled = enabled;
		((Control)txtSo_du_nt).Enabled = enabled;
	}

	private void txt_da_tt_nt_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtDa_tt_nt.Value, (object)0, false))
		{
			txtDa_tt.Value = Operators.MultiplyObject(txtTy_Gia.Value, txtDa_tt_nt.Value);
			txtda_tt_Validated(null, null);
		}
		TinhSoDu_Nt();
	}

	private void txtTien_PC_nt_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtTien_pc_nt.Value, (object)0, false))
		{
			txtTien_pc.Value = Operators.MultiplyObject(txtTy_Gia.Value, txtTien_pc_nt.Value);
			txtTien_pc_Validated(null, null);
		}
		TinhSoDu_Nt();
	}

	private void TinhSoDu_Nt()
	{
		txtSo_du_nt.Value = Operators.SubtractObject(txtTien_pc_nt.Value, txtDa_tt_nt.Value);
	}

	private void TinhSoDu()
	{
		txtSo_du.Value = Operators.SubtractObject(txtTien_pc.Value, txtDa_tt.Value);
	}

	private void txtda_tt_Validated(object sender, EventArgs e)
	{
		if (Operators.CompareString(((ComboBox)cboNt).Text, "VND", false) == 0)
		{
			txtDa_tt_nt.Value = RuntimeHelpers.GetObjectValue(txtDa_tt.Value);
		}
		TinhSoDu();
		TinhSoDu_Nt();
	}

	private void txtTien_pc_Validated(object sender, EventArgs e)
	{
		if (Operators.CompareString(((ComboBox)cboNt).Text, "VND", false) == 0)
		{
			txtTien_pc_nt.Value = RuntimeHelpers.GetObjectValue(txtTien_pc.Value);
		}
		TinhSoDu();
		TinhSoDu_Nt();
	}

	private void txtSo_du_nt_TextChanged(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectLessEqual(txtSo_du_nt.Value, (object)0, false))
		{
			chk_TT.Checked = true;
		}
		else
		{
			chk_TT.Checked = false;
		}
	}

	private bool CanhBaoDieuChinh()
	{
		if (Conversions.ToDouble(AsiaErp.Framework.Environment.GetSIConfiguration().canh_bao_dieu_chinh) == 0.0)
		{
			return true;
		}
		int num = checked((int)Math.Round(AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_gia_toi_da));
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectGreater(txtTien_pc.Value, Operators.AddObject(Operators.MultiplyObject(txtTien_pc_nt.Value, txtTy_Gia.Value), (object)num), false), Operators.CompareObjectLess(txtTien_pc.Value, Operators.SubtractObject(Operators.MultiplyObject(txtTien_pc_nt.Value, txtTy_Gia.Value), (object)num), false))))
		{
			epNotice.SetError((Control)(object)txtTien_pc, Helper.GetMess(50047).Description);
			((Control)txtTien_pc).Select();
			return Commons.ProcessAdjustOver();
		}
		epNotice.SetError((Control)(object)txtTien_pc, "");
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectGreater(txtDa_tt.Value, Operators.AddObject(Operators.MultiplyObject(txtDa_tt_nt.Value, txtTy_Gia.Value), (object)num), false), Operators.CompareObjectLess(txtDa_tt.Value, Operators.SubtractObject(Operators.MultiplyObject(txtDa_tt_nt.Value, txtTy_Gia.Value), (object)num), false))))
		{
			epNotice.SetError((Control)(object)txtDa_tt, Helper.GetMess(50047).Description);
			((Control)txtDa_tt).Select();
			return Commons.ProcessAdjustOver();
		}
		epNotice.SetError((Control)(object)txtDa_tt, "");
		return true;
	}
}
