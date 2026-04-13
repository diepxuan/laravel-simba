using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmINRptBKX04 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblNhom_theo")]
	private Label _lblNhom_theo;

	[AccessedThroughProperty("cboNhom_theo")]
	private AsComboBox _cboNhom_theo;

	[AccessedThroughProperty("lblTheo_DVT")]
	private Label _lblTheo_DVT;

	[AccessedThroughProperty("lblLoai_phieu")]
	private Label _lblLoai_phieu;

	[AccessedThroughProperty("txtTK")]
	private AsTextBox _txtTK;

	[AccessedThroughProperty("lblTen_TK")]
	private Label _lblTen_TK;

	[AccessedThroughProperty("lblTK")]
	private Label _lblTK;

	[AccessedThroughProperty("cboTheo_DVT")]
	private AsComboBox _cboTheo_DVT;

	[AccessedThroughProperty("txtTK_DU")]
	private AsTextBox _txtTK_DU;

	[AccessedThroughProperty("lblTen_TKDU")]
	private Label _lblTen_TKDU;

	[AccessedThroughProperty("lblTK_DU")]
	private Label _lblTK_DU;

	[AccessedThroughProperty("txtMa_BP")]
	private AsTextBox _txtMa_BP;

	[AccessedThroughProperty("lblTen_BP")]
	private Label _lblTen_BP;

	[AccessedThroughProperty("lblMa_BP")]
	private Label _lblMa_BP;

	[AccessedThroughProperty("txtMa_SPCT")]
	private AsTextBox _txtMa_SPCT;

	[AccessedThroughProperty("lblTen_SPCT")]
	private Label _lblTen_SPCT;

	[AccessedThroughProperty("lblMa_SPCT")]
	private Label _lblMa_SPCT;

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("lblTen_hd")]
	private Label _lblTen_hd;

	[AccessedThroughProperty("lblMa_hd")]
	private Label _lblMa_hd;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("txtMa_nhvt")]
	private AsTextBox _txtMa_nhvt;

	[AccessedThroughProperty("lblTen_nhvt")]
	private Label _lblTen_nhvt;

	[AccessedThroughProperty("lblMa_nhvt")]
	private Label _lblMa_nhvt;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("txtSo_ct2")]
	private TextBox _txtSo_ct2;

	[AccessedThroughProperty("txtSo_ct1")]
	private TextBox _txtSo_ct1;

	[AccessedThroughProperty("lblSo_ct2")]
	private Label _lblSo_ct2;

	[AccessedThroughProperty("lblSo_Ct1")]
	private Label _lblSo_Ct1;

	[AccessedThroughProperty("txtMa_kh")]
	private AsTextBox _txtMa_kh;

	[AccessedThroughProperty("lblTen_kh")]
	private Label _lblTen_kh;

	[AccessedThroughProperty("lblMa_kh")]
	private Label _lblMa_kh;

	[AccessedThroughProperty("cboLoai_phieu")]
	private AsComboBox _cboLoai_phieu;

	[AccessedThroughProperty("cboLoai_gd")]
	private ComboBox _cboLoai_gd;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("lblTen_lo")]
	private Label _lblTen_lo;

	[AccessedThroughProperty("txtMa_lo")]
	private AsTextBox _txtMa_lo;

	[AccessedThroughProperty("lblMaLo")]
	private Label _lblMaLo;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("lblTenPhi")]
	private Label _lblTenPhi;

	[AccessedThroughProperty("txtMa_Phi")]
	private AsTextBox _txtMa_Phi;

	internal virtual Label lblNhom_theo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNhom_theo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNhom_theo = value;
		}
	}

	internal virtual AsComboBox cboNhom_theo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboNhom_theo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboNhom_theo = value;
		}
	}

	internal virtual Label lblTheo_DVT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTheo_DVT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTheo_DVT = value;
		}
	}

	internal virtual Label lblLoai_phieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLoai_phieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLoai_phieu = value;
		}
	}

	private virtual AsTextBox txtTK
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK = value;
		}
	}

	private virtual Label lblTen_TK
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_TK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_TK = value;
		}
	}

	internal virtual Label lblTK
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK = value;
		}
	}

	internal virtual AsComboBox cboTheo_DVT
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboTheo_DVT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboTheo_DVT = value;
		}
	}

	private virtual AsTextBox txtTK_DU
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_DU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_DU = value;
		}
	}

	private virtual Label lblTen_TKDU
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_TKDU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_TKDU = value;
		}
	}

	internal virtual Label lblTK_DU
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_DU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_DU = value;
		}
	}

	private virtual AsTextBox txtMa_BP
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_BP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_BP = value;
		}
	}

	private virtual Label lblTen_BP
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_BP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_BP = value;
		}
	}

	internal virtual Label lblMa_BP
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_BP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_BP = value;
		}
	}

	private virtual AsTextBox txtMa_SPCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_SPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_SPCT = value;
		}
	}

	private virtual Label lblTen_SPCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_SPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_SPCT = value;
		}
	}

	internal virtual Label lblMa_SPCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_SPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_SPCT = value;
		}
	}

	private virtual AsTextBox txtMa_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_hd = value;
		}
	}

	private virtual Label lblTen_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_hd = value;
		}
	}

	internal virtual Label lblMa_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_hd = value;
		}
	}

	private virtual AsTextBox txtMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_kho = value;
		}
	}

	private virtual Label lblTen_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kho = value;
		}
	}

	internal virtual Label lblMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_kho = value;
		}
	}

	private virtual AsTextBox txtMa_nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nhvt = value;
		}
	}

	private virtual Label lblTen_nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nhvt = value;
		}
	}

	internal virtual Label lblMa_nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nhvt = value;
		}
	}

	private virtual AsTextBox txtMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_vt = value;
		}
	}

	private virtual Label lblTen_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_vt = value;
		}
	}

	internal virtual Label lblMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_vt = value;
		}
	}

	internal virtual TextBox txtSo_ct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_ct2 = value;
		}
	}

	internal virtual TextBox txtSo_ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_ct1 = value;
		}
	}

	internal virtual Label lblSo_ct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_ct2 = value;
		}
	}

	internal virtual Label lblSo_Ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_Ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_Ct1 = value;
		}
	}

	private virtual AsTextBox txtMa_kh
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

	private virtual Label lblTen_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kh = value;
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

	internal virtual AsComboBox cboLoai_phieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_phieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboLoai_phieu_SelectedValueChanged;
			if (_cboLoai_phieu != null)
			{
				((ListControl)_cboLoai_phieu).SelectedValueChanged -= eventHandler;
			}
			_cboLoai_phieu = value;
			if (_cboLoai_phieu != null)
			{
				((ListControl)_cboLoai_phieu).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual ComboBox cboLoai_gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai_gd = value;
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

	internal virtual Label lblTen_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_lo = value;
		}
	}

	internal virtual AsTextBox txtMa_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_lo = value;
		}
	}

	internal virtual Label lblMaLo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMaLo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMaLo = value;
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

	internal virtual Label lblTenPhi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTenPhi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTenPhi = value;
		}
	}

	internal virtual AsTextBox txtMa_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Phi = value;
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

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
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
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
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
		//IL_28bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_28c7: Expected O, but got Unknown
		lblNhom_theo = new Label();
		cboNhom_theo = new AsComboBox();
		lblTheo_DVT = new Label();
		lblLoai_phieu = new Label();
		txtTK = new AsTextBox();
		lblTen_TK = new Label();
		lblTK = new Label();
		cboTheo_DVT = new AsComboBox();
		txtTK_DU = new AsTextBox();
		lblTen_TKDU = new Label();
		lblTK_DU = new Label();
		txtMa_BP = new AsTextBox();
		lblTen_BP = new Label();
		lblMa_BP = new Label();
		txtMa_SPCT = new AsTextBox();
		lblTen_SPCT = new Label();
		lblMa_SPCT = new Label();
		txtMa_hd = new AsTextBox();
		lblTen_hd = new Label();
		lblMa_hd = new Label();
		txtMa_kho = new AsTextBox();
		lblTen_kho = new Label();
		lblMa_kho = new Label();
		txtMa_nhvt = new AsTextBox();
		lblTen_nhvt = new Label();
		lblMa_nhvt = new Label();
		txtMa_vt = new AsTextBox();
		lblTen_vt = new Label();
		lblMa_vt = new Label();
		txtSo_ct2 = new TextBox();
		txtSo_ct1 = new TextBox();
		lblSo_ct2 = new Label();
		lblSo_Ct1 = new Label();
		txtMa_kh = new AsTextBox();
		lblTen_kh = new Label();
		lblMa_kh = new Label();
		cboLoai_phieu = new AsComboBox();
		cboLoai_gd = new ComboBox();
		Label2 = new Label();
		lblTen_lo = new Label();
		txtMa_lo = new AsTextBox();
		lblMaLo = new Label();
		Label8 = new Label();
		lblTenPhi = new Label();
		txtMa_Phi = new AsTextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(948, 585);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)Label8);
		((Control)tabFilter).Controls.Add((Control)(object)lblTenPhi);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lo);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_lo);
		((Control)tabFilter).Controls.Add((Control)(object)lblMaLo);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoai_gd);
		((Control)tabFilter).Controls.Add((Control)(object)Label2);
		((Control)tabFilter).Controls.Add((Control)(object)lblNhom_theo);
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom_theo);
		((Control)tabFilter).Controls.Add((Control)(object)lblTheo_DVT);
		((Control)tabFilter).Controls.Add((Control)(object)lblLoai_phieu);
		((Control)tabFilter).Controls.Add((Control)(object)txtTK);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_TK);
		((Control)tabFilter).Controls.Add((Control)(object)lblTK);
		((Control)tabFilter).Controls.Add((Control)(object)cboTheo_DVT);
		((Control)tabFilter).Controls.Add((Control)(object)txtTK_DU);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_TKDU);
		((Control)tabFilter).Controls.Add((Control)(object)lblTK_DU);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_BP);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_BP);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_BP);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_SPCT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_SPCT);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_SPCT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_ct2);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_ct1);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_ct2);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_Ct1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kh);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoai_phieu);
		TabPage obj = tabFilter;
		size = new Size(940, 556);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoai_phieu, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_Ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_SPCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_SPCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_SPCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_BP, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_BP, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_BP, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTK_DU, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_TKDU, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTK_DU, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboTheo_DVT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTK, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_TK, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTK, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblLoai_phieu, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTheo_DVT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom_theo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNhom_theo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoai_gd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMaLo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTenPhi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label8, 0);
		Label obj2 = lbl2;
		Point location = new Point(331, 78);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(886, 502);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 22;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(350, 74);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(805, 555);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 38;
		Button obj5 = cmdModifyReport;
		location = new Point(509, 23);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 201;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(260, 74);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(162, 74);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(23, 78);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(162, 25);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 200;
		Label obj9 = lblMau_bc;
		location = new Point(23, 28);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(162, 460);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 20;
		Label obj10 = lblMauBC;
		location = new Point(209, 464);
		((Control)obj10).Location = location;
		RadioButton obj11 = optVND;
		location = new Point(287, 462);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 21;
		RadioButton obj12 = optNt;
		location = new Point(341, 462);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 22;
		Label obj13 = lblMa_nt;
		location = new Point(23, 462);
		((Control)obj13).Location = location;
		Button obj14 = cmdOk;
		location = new Point(23, 503);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 23;
		Label obj15 = lblTieu_de;
		location = new Point(23, 54);
		((Control)obj15).Location = location;
		((Control)lblTieu_de).TabIndex = 24;
		TextBox obj16 = txtTieu_De;
		location = new Point(162, 50);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 202;
		lblNhom_theo.AutoSize = true;
		Label obj17 = lblNhom_theo;
		location = new Point(23, 126);
		((Control)obj17).Location = location;
		((Control)lblNhom_theo).Name = "lblNhom_theo";
		Label obj18 = lblNhom_theo;
		size = new Size(59, 13);
		((Control)obj18).Size = size;
		((Control)lblNhom_theo).TabIndex = 1295;
		lblNhom_theo.Text = "Nhóm theo";
		((ComboBox)cboNhom_theo).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom_theo).FormattingEnabled = true;
		((ComboBox)cboNhom_theo).Items.AddRange(new object[8] { "", "Nhà cung cấp", "Hợp đồng", "Dạng nhập xuất", "Sản phẩm, công trình", "Vật tư", "Bộ phận", "Chứng từ" });
		AsComboBox asComboBox = cboNhom_theo;
		location = new Point(162, 123);
		((Control)asComboBox).Location = location;
		((Control)cboNhom_theo).Name = "cboNhom_theo";
		AsComboBox asComboBox2 = cboNhom_theo;
		size = new Size(183, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboNhom_theo).TabIndex = 5;
		lblTheo_DVT.AutoSize = true;
		Label obj19 = lblTheo_DVT;
		location = new Point(23, 439);
		((Control)obj19).Location = location;
		((Control)lblTheo_DVT).Name = "lblTheo_DVT";
		Label obj20 = lblTheo_DVT;
		size = new Size(57, 13);
		((Control)obj20).Size = size;
		((Control)lblTheo_DVT).TabIndex = 1293;
		lblTheo_DVT.Text = "Theo ĐVT";
		lblLoai_phieu.AutoSize = true;
		Label obj21 = lblLoai_phieu;
		location = new Point(23, 103);
		((Control)obj21).Location = location;
		((Control)lblLoai_phieu).Name = "lblLoai_phieu";
		Label obj22 = lblLoai_phieu;
		size = new Size(79, 13);
		((Control)obj22).Size = size;
		((Control)lblLoai_phieu).TabIndex = 1292;
		lblLoai_phieu.Text = "Loại phiếu xuất";
		((TextBox)txtTK).AutoCompleteSource = (AutoCompleteSource)64;
		txtTK.AutoLookup = true;
		txtTK.AutoValid = false;
		((TextBoxBase)txtTK).BackColor = SystemColors.Info;
		((TextBox)txtTK).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTK;
		location = new Point(162, 244);
		((Control)asTextBox2).Location = location;
		txtTK.LookupCodeName = "TK";
		((Control)txtTK).Name = "txtTK";
		txtTK.NameControl = lblTen_TK;
		AsTextBox asTextBox3 = txtTK;
		size = new Size(88, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTK).TabIndex = 11;
		((Control)txtTK).Tag = "@pTK";
		txtTK.UseAutoCompleteSource = true;
		lblTen_TK.ImeMode = (ImeMode)0;
		Label obj23 = lblTen_TK;
		location = new Point(258, 248);
		((Control)obj23).Location = location;
		((Control)lblTen_TK).Name = "lblTen_TK";
		Label obj24 = lblTen_TK;
		size = new Size(366, 13);
		((Control)obj24).Size = size;
		((Control)lblTen_TK).TabIndex = 1291;
		lblTen_TK.TextAlign = (ContentAlignment)16;
		lblTK.AutoSize = true;
		Label obj25 = lblTK;
		location = new Point(23, 247);
		((Control)obj25).Location = location;
		((Control)lblTK).Name = "lblTK";
		Label obj26 = lblTK;
		size = new Size(85, 13);
		((Control)obj26).Size = size;
		((Control)lblTK).TabIndex = 1290;
		lblTK.Text = "Tài khoản vật tư";
		((ComboBox)cboTheo_DVT).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboTheo_DVT).FormattingEnabled = true;
		((ComboBox)cboTheo_DVT).Items.AddRange(new object[4] { "Chứng từ", "Tồn kho", "Mua", "Bán" });
		AsComboBox asComboBox3 = cboTheo_DVT;
		location = new Point(162, 436);
		((Control)asComboBox3).Location = location;
		((Control)cboTheo_DVT).Name = "cboTheo_DVT";
		AsComboBox asComboBox4 = cboTheo_DVT;
		size = new Size(90, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboTheo_DVT).TabIndex = 19;
		((TextBox)txtTK_DU).AutoCompleteSource = (AutoCompleteSource)64;
		txtTK_DU.AutoLookup = true;
		txtTK_DU.AutoValid = false;
		((TextBoxBase)txtTK_DU).BackColor = SystemColors.Info;
		((TextBox)txtTK_DU).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtTK_DU;
		location = new Point(162, 268);
		((Control)asTextBox4).Location = location;
		txtTK_DU.LookupCodeName = "TK";
		((Control)txtTK_DU).Name = "txtTK_DU";
		txtTK_DU.NameControl = lblTen_TKDU;
		AsTextBox asTextBox5 = txtTK_DU;
		size = new Size(88, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtTK_DU).TabIndex = 12;
		((Control)txtTK_DU).Tag = "@pTK";
		txtTK_DU.UseAutoCompleteSource = true;
		lblTen_TKDU.ImeMode = (ImeMode)0;
		Label obj27 = lblTen_TKDU;
		location = new Point(261, 272);
		((Control)obj27).Location = location;
		((Control)lblTen_TKDU).Name = "lblTen_TKDU";
		Label obj28 = lblTen_TKDU;
		size = new Size(366, 13);
		((Control)obj28).Size = size;
		((Control)lblTen_TKDU).TabIndex = 1289;
		lblTen_TKDU.TextAlign = (ContentAlignment)16;
		lblTK_DU.AutoSize = true;
		Label obj29 = lblTK_DU;
		location = new Point(23, 271);
		((Control)obj29).Location = location;
		((Control)lblTK_DU).Name = "lblTK_DU";
		Label obj30 = lblTK_DU;
		size = new Size(74, 13);
		((Control)obj30).Size = size;
		((Control)lblTK_DU).TabIndex = 1288;
		lblTK_DU.Text = "Tài khoản ĐƯ";
		((TextBox)txtMa_BP).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_BP.AutoLookup = true;
		txtMa_BP.AutoValid = false;
		((TextBoxBase)txtMa_BP).BackColor = SystemColors.Info;
		((TextBox)txtMa_BP).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_BP;
		location = new Point(162, 364);
		((Control)asTextBox6).Location = location;
		txtMa_BP.LookupCodeName = "Ma_BP";
		((Control)txtMa_BP).Name = "txtMa_BP";
		txtMa_BP.NameControl = lblTen_BP;
		AsTextBox asTextBox7 = txtMa_BP;
		size = new Size(88, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_BP).TabIndex = 16;
		((Control)txtMa_BP).Tag = "@pMa_bp";
		txtMa_BP.UseAutoCompleteSource = true;
		lblTen_BP.ImeMode = (ImeMode)0;
		Label obj31 = lblTen_BP;
		location = new Point(261, 368);
		((Control)obj31).Location = location;
		((Control)lblTen_BP).Name = "lblTen_BP";
		Label obj32 = lblTen_BP;
		size = new Size(366, 13);
		((Control)obj32).Size = size;
		((Control)lblTen_BP).TabIndex = 1287;
		lblTen_BP.TextAlign = (ContentAlignment)16;
		lblMa_BP.AutoSize = true;
		Label obj33 = lblMa_BP;
		location = new Point(23, 367);
		((Control)obj33).Location = location;
		((Control)lblMa_BP).Name = "lblMa_BP";
		Label obj34 = lblMa_BP;
		size = new Size(64, 13);
		((Control)obj34).Size = size;
		((Control)lblMa_BP).TabIndex = 1286;
		lblMa_BP.Text = "Mã bộ phận";
		((TextBox)txtMa_SPCT).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_SPCT.AutoLookup = true;
		txtMa_SPCT.AutoValid = false;
		((TextBoxBase)txtMa_SPCT).BackColor = SystemColors.Info;
		((TextBox)txtMa_SPCT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_SPCT;
		location = new Point(162, 340);
		((Control)asTextBox8).Location = location;
		txtMa_SPCT.LookupCodeName = "Ma_SPCT";
		((Control)txtMa_SPCT).Name = "txtMa_SPCT";
		txtMa_SPCT.NameControl = lblTen_SPCT;
		AsTextBox asTextBox9 = txtMa_SPCT;
		size = new Size(88, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_SPCT).TabIndex = 15;
		((Control)txtMa_SPCT).Tag = "@pMa_SPCT";
		txtMa_SPCT.UseAutoCompleteSource = true;
		lblTen_SPCT.ImeMode = (ImeMode)0;
		Label obj35 = lblTen_SPCT;
		location = new Point(261, 344);
		((Control)obj35).Location = location;
		((Control)lblTen_SPCT).Name = "lblTen_SPCT";
		Label obj36 = lblTen_SPCT;
		size = new Size(366, 13);
		((Control)obj36).Size = size;
		((Control)lblTen_SPCT).TabIndex = 1285;
		lblTen_SPCT.TextAlign = (ContentAlignment)16;
		lblMa_SPCT.AutoSize = true;
		Label obj37 = lblMa_SPCT;
		location = new Point(23, 343);
		((Control)obj37).Location = location;
		((Control)lblMa_SPCT).Name = "lblMa_SPCT";
		Label obj38 = lblMa_SPCT;
		size = new Size(76, 13);
		((Control)obj38).Size = size;
		((Control)lblMa_SPCT).TabIndex = 1284;
		lblMa_SPCT.Text = "S/P công trình";
		((TextBox)txtMa_hd).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = false;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_hd;
		location = new Point(162, 316);
		((Control)asTextBox10).Location = location;
		txtMa_hd.LookupCodeName = "Ma_hd";
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_hd;
		AsTextBox asTextBox11 = txtMa_hd;
		size = new Size(88, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_hd).TabIndex = 14;
		((Control)txtMa_hd).Tag = "@pMa_hd";
		txtMa_hd.UseAutoCompleteSource = true;
		lblTen_hd.ImeMode = (ImeMode)0;
		Label obj39 = lblTen_hd;
		location = new Point(259, 321);
		((Control)obj39).Location = location;
		((Control)lblTen_hd).Name = "lblTen_hd";
		Label obj40 = lblTen_hd;
		size = new Size(366, 13);
		((Control)obj40).Size = size;
		((Control)lblTen_hd).TabIndex = 1282;
		lblTen_hd.TextAlign = (ContentAlignment)16;
		lblMa_hd.AutoSize = true;
		Label obj41 = lblMa_hd;
		location = new Point(23, 319);
		((Control)obj41).Location = location;
		((Control)lblMa_hd).Name = "lblMa_hd";
		Label obj42 = lblMa_hd;
		size = new Size(71, 13);
		((Control)obj42).Size = size;
		((Control)lblMa_hd).TabIndex = 1280;
		lblMa_hd.Text = "Mã hợp đồng";
		((TextBox)txtMa_kho).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_kho;
		location = new Point(162, 172);
		((Control)asTextBox12).Location = location;
		txtMa_kho.LookupCodeName = "Ma_kho";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox13 = txtMa_kho;
		size = new Size(88, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_kho).TabIndex = 8;
		((Control)txtMa_kho).Tag = "@pMa_kho";
		txtMa_kho.UseAutoCompleteSource = true;
		lblTen_kho.ImeMode = (ImeMode)0;
		Label obj43 = lblTen_kho;
		location = new Point(261, 176);
		((Control)obj43).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj44 = lblTen_kho;
		size = new Size(366, 13);
		((Control)obj44).Size = size;
		((Control)lblTen_kho).TabIndex = 1279;
		lblTen_kho.TextAlign = (ContentAlignment)16;
		lblMa_kho.AutoSize = true;
		Label obj45 = lblMa_kho;
		location = new Point(23, 175);
		((Control)obj45).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj46 = lblMa_kho;
		size = new Size(66, 13);
		((Control)obj46).Size = size;
		((Control)lblMa_kho).TabIndex = 1278;
		lblMa_kho.Text = "Mã kho xuất";
		((TextBox)txtMa_nhvt).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_nhvt.AutoLookup = true;
		txtMa_nhvt.AutoValid = false;
		((TextBoxBase)txtMa_nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtMa_nhvt;
		location = new Point(162, 220);
		((Control)asTextBox14).Location = location;
		txtMa_nhvt.LookupCodeName = "Ma_nhvt";
		((Control)txtMa_nhvt).Name = "txtMa_nhvt";
		txtMa_nhvt.NameControl = lblTen_nhvt;
		AsTextBox asTextBox15 = txtMa_nhvt;
		size = new Size(88, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_nhvt).TabIndex = 10;
		((Control)txtMa_nhvt).Tag = "@pMa_nhvt";
		txtMa_nhvt.UseAutoCompleteSource = true;
		lblTen_nhvt.ImeMode = (ImeMode)0;
		Label obj47 = lblTen_nhvt;
		location = new Point(259, 223);
		((Control)obj47).Location = location;
		((Control)lblTen_nhvt).Name = "lblTen_nhvt";
		Label obj48 = lblTen_nhvt;
		size = new Size(366, 13);
		((Control)obj48).Size = size;
		((Control)lblTen_nhvt).TabIndex = 1277;
		lblTen_nhvt.TextAlign = (ContentAlignment)16;
		lblMa_nhvt.AutoSize = true;
		Label obj49 = lblMa_nhvt;
		location = new Point(23, 223);
		((Control)obj49).Location = location;
		((Control)lblMa_nhvt).Name = "lblMa_nhvt";
		Label obj50 = lblMa_nhvt;
		size = new Size(81, 13);
		((Control)obj50).Size = size;
		((Control)lblMa_nhvt).TabIndex = 1276;
		lblMa_nhvt.Text = "Mã nhóm vật tư";
		((TextBox)txtMa_vt).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox16 = txtMa_vt;
		location = new Point(162, 196);
		((Control)asTextBox16).Location = location;
		txtMa_vt.LookupCodeName = "Ma_vt";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox17 = txtMa_vt;
		size = new Size(88, 20);
		((Control)asTextBox17).Size = size;
		((Control)txtMa_vt).TabIndex = 9;
		((Control)txtMa_vt).Tag = "@pMa_vt";
		txtMa_vt.UseAutoCompleteSource = true;
		lblTen_vt.ImeMode = (ImeMode)0;
		Label obj51 = lblTen_vt;
		location = new Point(259, 198);
		((Control)obj51).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj52 = lblTen_vt;
		size = new Size(366, 13);
		((Control)obj52).Size = size;
		((Control)lblTen_vt).TabIndex = 1275;
		lblTen_vt.TextAlign = (ContentAlignment)16;
		lblMa_vt.AutoSize = true;
		Label obj53 = lblMa_vt;
		location = new Point(23, 199);
		((Control)obj53).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj54 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj54).Size = size;
		((Control)lblMa_vt).TabIndex = 1274;
		lblMa_vt.Text = "Mã vật tư";
		TextBox obj55 = txtSo_ct2;
		location = new Point(328, 148);
		((Control)obj55).Location = location;
		((Control)txtSo_ct2).Name = "txtSo_ct2";
		TextBox obj56 = txtSo_ct2;
		size = new Size(90, 20);
		((Control)obj56).Size = size;
		((Control)txtSo_ct2).TabIndex = 7;
		TextBox obj57 = txtSo_ct1;
		location = new Point(162, 148);
		((Control)obj57).Location = location;
		((Control)txtSo_ct1).Name = "txtSo_ct1";
		TextBox obj58 = txtSo_ct1;
		size = new Size(90, 20);
		((Control)obj58).Size = size;
		((Control)txtSo_ct1).TabIndex = 6;
		lblSo_ct2.AutoSize = true;
		Label obj59 = lblSo_ct2;
		location = new Point(272, 151);
		((Control)obj59).Location = location;
		((Control)lblSo_ct2).Name = "lblSo_ct2";
		Label obj60 = lblSo_ct2;
		size = new Size(40, 13);
		((Control)obj60).Size = size;
		((Control)lblSo_ct2).TabIndex = 1273;
		lblSo_ct2.Text = "đến số";
		lblSo_Ct1.AutoSize = true;
		Label obj61 = lblSo_Ct1;
		location = new Point(23, 151);
		((Control)obj61).Location = location;
		((Control)lblSo_Ct1).Name = "lblSo_Ct1";
		Label obj62 = lblSo_Ct1;
		size = new Size(49, 13);
		((Control)obj62).Size = size;
		((Control)lblSo_Ct1).TabIndex = 1272;
		lblSo_Ct1.Text = "Ctừ từ số";
		((TextBox)txtMa_kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_kh.AutoLookup = true;
		txtMa_kh.AutoValid = false;
		((TextBoxBase)txtMa_kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox18 = txtMa_kh;
		location = new Point(162, 292);
		((Control)asTextBox18).Location = location;
		txtMa_kh.LookupCodeName = "Ma_kh";
		((Control)txtMa_kh).Name = "txtMa_kh";
		txtMa_kh.NameControl = lblTen_kh;
		AsTextBox asTextBox19 = txtMa_kh;
		size = new Size(88, 20);
		((Control)asTextBox19).Size = size;
		((Control)txtMa_kh).TabIndex = 13;
		((Control)txtMa_kh).Tag = "@pMa_kh";
		txtMa_kh.UseAutoCompleteSource = true;
		lblTen_kh.ImeMode = (ImeMode)0;
		Label obj63 = lblTen_kh;
		location = new Point(259, 295);
		((Control)obj63).Location = location;
		((Control)lblTen_kh).Name = "lblTen_kh";
		Label obj64 = lblTen_kh;
		size = new Size(366, 13);
		((Control)obj64).Size = size;
		((Control)lblTen_kh).TabIndex = 1271;
		lblTen_kh.TextAlign = (ContentAlignment)16;
		lblMa_kh.AutoSize = true;
		Label obj65 = lblMa_kh;
		location = new Point(23, 295);
		((Control)obj65).Location = location;
		((Control)lblMa_kh).Name = "lblMa_kh";
		Label obj66 = lblMa_kh;
		size = new Size(82, 13);
		((Control)obj66).Size = size;
		((Control)lblMa_kh).TabIndex = 1270;
		lblMa_kh.Text = "Mã khách hàng";
		((ComboBox)cboLoai_phieu).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_phieu).FormattingEnabled = true;
		AsComboBox asComboBox5 = cboLoai_phieu;
		location = new Point(162, 99);
		((Control)asComboBox5).Location = location;
		((Control)cboLoai_phieu).Name = "cboLoai_phieu";
		AsComboBox asComboBox6 = cboLoai_phieu;
		size = new Size(183, 21);
		((Control)asComboBox6).Size = size;
		((Control)cboLoai_phieu).TabIndex = 3;
		cboLoai_gd.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_gd).FormattingEnabled = true;
		ComboBox obj67 = cboLoai_gd;
		location = new Point(442, 99);
		((Control)obj67).Location = location;
		((Control)cboLoai_gd).Name = "cboLoai_gd";
		ComboBox obj68 = cboLoai_gd;
		size = new Size(142, 21);
		((Control)obj68).Size = size;
		((Control)cboLoai_gd).TabIndex = 4;
		Label2.AutoSize = true;
		Label label = Label2;
		location = new Point(362, 103);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(73, 13);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 1297;
		Label2.Text = "Loại giao dịch";
		Label obj69 = lblTen_lo;
		location = new Point(255, 416);
		((Control)obj69).Location = location;
		((Control)lblTen_lo).Name = "lblTen_lo";
		Label obj70 = lblTen_lo;
		size = new Size(515, 13);
		((Control)obj70).Size = size;
		((Control)lblTen_lo).TabIndex = 1310;
		txtMa_lo.AutoLookup = true;
		txtMa_lo.AutoValid = false;
		((TextBoxBase)txtMa_lo).BackColor = SystemColors.Info;
		((TextBox)txtMa_lo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox20 = txtMa_lo;
		location = new Point(162, 412);
		((Control)asTextBox20).Location = location;
		txtMa_lo.LookupCodeName = "MA_LO";
		((Control)txtMa_lo).Name = "txtMa_lo";
		txtMa_lo.NameControl = lblTen_lo;
		AsTextBox asTextBox21 = txtMa_lo;
		size = new Size(90, 20);
		((Control)asTextBox21).Size = size;
		((Control)txtMa_lo).TabIndex = 18;
		((Control)txtMa_lo).Tag = "MA_LO";
		txtMa_lo.UseAutoCompleteSource = true;
		lblMaLo.AutoSize = true;
		Label obj71 = lblMaLo;
		location = new Point(23, 416);
		((Control)obj71).Location = location;
		((Control)lblMaLo).Name = "lblMaLo";
		Label obj72 = lblMaLo;
		size = new Size(33, 13);
		((Control)obj72).Size = size;
		((Control)lblMaLo).TabIndex = 1311;
		lblMaLo.Text = "Mã lô";
		Label8.AutoSize = true;
		Label label3 = Label8;
		location = new Point(23, 392);
		((Control)label3).Location = location;
		((Control)Label8).Name = "Label8";
		Label label4 = Label8;
		size = new Size(41, 13);
		((Control)label4).Size = size;
		((Control)Label8).TabIndex = 1314;
		Label8.Text = "Mã phí";
		Label obj73 = lblTenPhi;
		location = new Point(258, 392);
		((Control)obj73).Location = location;
		((Control)lblTenPhi).Name = "lblTenPhi";
		Label obj74 = lblTenPhi;
		size = new Size(479, 13);
		((Control)obj74).Size = size;
		((Control)lblTenPhi).TabIndex = 1313;
		txtMa_Phi.AutoLookup = true;
		txtMa_Phi.AutoValid = false;
		((TextBoxBase)txtMa_Phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_Phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox22 = txtMa_Phi;
		location = new Point(162, 388);
		((Control)asTextBox22).Location = location;
		txtMa_Phi.LookupCodeName = "MA_PHI";
		((Control)txtMa_Phi).Name = "txtMa_Phi";
		txtMa_Phi.NameControl = lblTenPhi;
		AsTextBox asTextBox23 = txtMa_Phi;
		size = new Size(90, 20);
		((Control)asTextBox23).Size = size;
		((Control)txtMa_Phi).TabIndex = 17;
		((Control)txtMa_Phi).Tag = "MA_PHI";
		txtMa_Phi.UseAutoCompleteSource = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(948, 607);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmINRptBKX04";
		((Form)this).Text = "frmINRptBKX04";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public frmINRptBKX04(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
		AsComboBox asComboBox = cboLoai_phieu;
		((ComboBox)asComboBox).DataSource = AsiaErp.Framework.Environment.GetDanhSachChungTuXuat();
		((ListControl)asComboBox).DisplayMember = "Value";
		((ListControl)asComboBox).ValueMember = "Key";
		((ComboBox)asComboBox).SelectedIndex = 0;
		asComboBox = null;
		AsComboBox asComboBox2 = cboNhom_theo;
		ArrayList arrayList = new ArrayList();
		DictionaryEntry dictionaryEntry = new DictionaryEntry("", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox2).Items[0]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("MA_KH", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox2).Items[1]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("Ma_HD", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox2).Items[2]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("Ma_NX", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox2).Items[3]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("Ma_SPCT", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox2).Items[4]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("Ma_VT", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox2).Items[5]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("Ma_BP", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox2).Items[6]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("Stt_rec", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox2).Items[7]));
		arrayList.Add(dictionaryEntry);
		((ComboBox)asComboBox2).Items.Clear();
		((ComboBox)asComboBox2).DataSource = arrayList;
		((ListControl)asComboBox2).ValueMember = "Key";
		((ListControl)asComboBox2).DisplayMember = "Value";
		((ComboBox)cboNhom_theo).SelectedIndex = 0;
		asComboBox2 = null;
		((ComboBox)cboTheo_DVT).SelectedIndex = 0;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		DictionaryEntry dictionaryEntry = (DictionaryEntry)((ComboBox)cboNhom_theo).SelectedItem;
		arrayList.Add(RuntimeHelpers.GetObjectValue(dictionaryEntry.Key));
		arrayList.Add(txtSo_ct1.Text);
		arrayList.Add(txtSo_ct2.Text);
		arrayList.Add(((TextBox)txtMa_kh).Text);
		arrayList.Add(((TextBox)txtMa_hd).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_SPCT).Text);
		arrayList.Add(((TextBox)txtMa_BP).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_phieu).SelectedValue));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_gd).SelectedValue));
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		arrayList.Add(((TextBox)txtMa_vt).Text);
		arrayList.Add(((TextBox)txtMa_nhvt).Text);
		arrayList.Add(((TextBox)txtTK).Text);
		arrayList.Add(((TextBox)txtTK_DU).Text);
		arrayList.Add(((TextBox)txtMa_lo).Text.Trim());
		arrayList.Add(((TextBox)txtMa_Phi).Text.Trim());
		arrayList.Add(((ComboBox)cboTheo_DVT).SelectedIndex);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		text = text + lblNhom_theo.Text + ": [" + ((ComboBox)cboNhom_theo).Text + "]; ";
		if (Operators.ConditionalCompareObjectNotEqual(((ListControl)cboLoai_phieu).SelectedValue, (object)"", false))
		{
			text = text + lblLoai_phieu.Text + ": [" + ((ComboBox)cboLoai_phieu).Text + "]; ";
		}
		if (Operators.CompareString(txtSo_ct1.Text, "", false) != 0)
		{
			text = text + lblSo_Ct1.Text + ": [" + txtSo_ct1.Text + "]; ";
		}
		if (Operators.CompareString(txtSo_ct2.Text, "", false) != 0)
		{
			text = text + lblSo_ct2.Text + ": [" + txtSo_ct2.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kh).Text, "", false) != 0)
		{
			text = text + lblMa_kh.Text + ": [" + ((TextBox)txtMa_kh).Text + " - " + lblTen_kh.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhvt).Text, "", false) != 0)
		{
			text = text + lblMa_nhvt.Text + ": [" + ((TextBox)txtMa_nhvt).Text + " - " + lblTen_nhvt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text, "", false) != 0)
		{
			text = text + lblMa_vt.Text + ": [" + ((TextBox)txtMa_vt).Text + " - " + lblTen_vt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_hd).Text, "", false) != 0)
		{
			text = text + lblMa_hd.Text + ": [" + ((TextBox)txtMa_hd).Text + " - " + lblTen_hd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtTK).Text, "", false) != 0)
		{
			text = text + lblTK.Text + ": [" + ((TextBox)txtTK).Text + " - " + lblTen_TK.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_SPCT).Text, "", false) != 0)
		{
			text = text + lblMa_SPCT.Text + ": [" + ((TextBox)txtMa_SPCT).Text + " - " + lblTen_SPCT.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_BP).Text, "", false) != 0)
		{
			text = text + lblMa_BP.Text + ": [" + ((TextBox)txtMa_BP).Text + " - " + lblTen_BP.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtTK_DU).Text, "", false) != 0)
		{
			text = text + lblTK_DU.Text + ": [" + ((TextBox)txtTK_DU).Text + " - " + lblTen_TKDU.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kho).Text, "", false) != 0)
		{
			text = text + lblMa_kho.Text + ": [" + ((TextBox)txtMa_kho).Text + " - " + lblTen_kho.Text + "]; ";
		}
		if (Operators.ConditionalCompareObjectNotEqual(((ListControl)cboTheo_DVT).SelectedValue, (object)"", false))
		{
			text = text + lblTheo_DVT.Text + ": [" + ((ComboBox)cboTheo_DVT).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": [" + ((TextBox)txtMa_Nt).Text + "]; ";
		}
		return text;
	}

	private void SetDataSourceToCmb(ComboBox combobox, ArrayList ar, string member, string value)
	{
		ArrayList arrayList = new ArrayList();
		DmMaGd dmMaGd = new DmMaGd();
		dmMaGd.ma_ct = ((ListControl)cboLoai_phieu).SelectedValue.ToString();
		dmMaGd.ma_gd = Conversions.ToString(0);
		dmMaGd.mo_ta = AsiaErp.Framework.Environment.getLangSysMessageResX("#SYS_ALL").value;
		dmMaGd.ngam_dinh = true;
		arrayList.Add(dmMaGd);
		if (ar != null)
		{
			foreach (DmMaGd item in ar)
			{
				arrayList.Add(item);
			}
		}
		combobox.DataSource = arrayList;
		((ListControl)combobox).DisplayMember = member;
		((ListControl)combobox).ValueMember = value;
		combobox.SelectedIndex = 0;
	}

	private void cboLoai_phieu_SelectedValueChanged(object sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			SetDataSourceToCmb(cboLoai_gd, AsiaErp.Framework.Environment.GetDmMagd(((ListControl)cboLoai_phieu).SelectedValue.ToString()), "mo_ta", "ma_gd");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}
}
