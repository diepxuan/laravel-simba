using System;
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
public class frmARDMKHEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_Kh")]
	private TextBox _txtMa_Kh;

	[AccessedThroughProperty("txtTen_Kh")]
	private TextBox _txtTen_Kh;

	[AccessedThroughProperty("lbTen_KH")]
	private Label _lbTen_KH;

	[AccessedThroughProperty("lbMa_KH")]
	private Label _lbMa_KH;

	[AccessedThroughProperty("lblDia_Chi")]
	private Label _lblDia_Chi;

	[AccessedThroughProperty("txtTel")]
	private TextBox _txtTel;

	[AccessedThroughProperty("txtDia_chi")]
	private TextBox _txtDia_chi;

	[AccessedThroughProperty("txtFax")]
	private TextBox _txtFax;

	[AccessedThroughProperty("txtMA_HTTT")]
	private AsTextBox _txtMA_HTTT;

	[AccessedThroughProperty("lblTen_HTTT")]
	private Label _lblTen_HTTT;

	[AccessedThroughProperty("txtNguoi_Gd")]
	private TextBox _txtNguoi_Gd;

	[AccessedThroughProperty("txtMa_so_thue")]
	private TextBox _txtMa_so_thue;

	[AccessedThroughProperty("txtEmail")]
	private TextBox _txtEmail;

	[AccessedThroughProperty("txtGh_No")]
	private AsTextNumeric _txtGh_No;

	[AccessedThroughProperty("txtGhi_Chu")]
	private TextBox _txtGhi_Chu;

	[AccessedThroughProperty("txtHome_page")]
	private TextBox _txtHome_page;

	[AccessedThroughProperty("lblNguoi_Gd")]
	private Label _lblNguoi_Gd;

	[AccessedThroughProperty("lblMa_So_Thue")]
	private Label _lblMa_So_Thue;

	[AccessedThroughProperty("chkIsNv")]
	private AsCheckBox _chkIsNv;

	[AccessedThroughProperty("lblHome_page")]
	private Label _lblHome_page;

	[AccessedThroughProperty("lblEmail")]
	private Label _lblEmail;

	[AccessedThroughProperty("lblGh_No")]
	private Label _lblGh_No;

	[AccessedThroughProperty("lblFax")]
	private Label _lblFax;

	[AccessedThroughProperty("chkIsNcc")]
	private AsCheckBox _chkIsNcc;

	[AccessedThroughProperty("lblTel")]
	private Label _lblTel;

	[AccessedThroughProperty("lblGhi_Chu")]
	private Label _lblGhi_Chu;

	[AccessedThroughProperty("chkTinh_dt_nb")]
	private AsCheckBox _chkTinh_dt_nb;

	[AccessedThroughProperty("chkIsKh")]
	private AsCheckBox _chkIsKh;

	[AccessedThroughProperty("lblTK")]
	private Label _lblTK;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtMA_HTTT_PO")]
	private AsTextBox _txtMA_HTTT_PO;

	[AccessedThroughProperty("lblTen_HTTT_PO")]
	private Label _lblTen_HTTT_PO;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtHan_tt")]
	private AsTextNumeric _txtHan_tt;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("txtTinh_tp_nh")]
	private TextBox _txtTinh_tp_nh;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("txtCn_nh")]
	private TextBox _txtCn_nh;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("txtSo_tk_nh")]
	private TextBox _txtSo_tk_nh;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtMa_Ngh")]
	private AsTextBox _txtMa_Ngh;

	[AccessedThroughProperty("lblTen_nh")]
	private Label _lblTen_nh;

	[AccessedThroughProperty("txtMa_PlKh1")]
	private AsTextBox _txtMa_PlKh1;

	[AccessedThroughProperty("lblTen_Plkh1")]
	private Label _lblTen_Plkh1;

	[AccessedThroughProperty("txtMa_PlKh2")]
	private AsTextBox _txtMa_PlKh2;

	[AccessedThroughProperty("lblTen_Plkh2")]
	private Label _lblTen_Plkh2;

	[AccessedThroughProperty("txtMa_PlKh3")]
	private AsTextBox _txtMa_PlKh3;

	[AccessedThroughProperty("lblTen_Plkh3")]
	private Label _lblTen_Plkh3;

	[AccessedThroughProperty("lblMa_Plkh3")]
	private Label _lblMa_Plkh3;

	[AccessedThroughProperty("lblMa_Plkh1")]
	private Label _lblMa_Plkh1;

	[AccessedThroughProperty("lblMa_Plkh2")]
	private Label _lblMa_Plkh2;

	internal virtual TextBox txtMa_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Kh = value;
		}
	}

	internal virtual TextBox txtTen_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Kh = value;
		}
	}

	internal virtual Label lbTen_KH
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbTen_KH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbTen_KH = value;
		}
	}

	internal virtual Label lbMa_KH
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbMa_KH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbMa_KH = value;
		}
	}

	internal virtual Label lblDia_Chi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDia_Chi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDia_Chi = value;
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
			_txtTel = value;
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

	internal virtual TextBox txtFax
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFax;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtFax = value;
		}
	}

	internal virtual AsTextBox txtMA_HTTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMA_HTTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMA_HTTT = value;
		}
	}

	internal virtual Label lblTen_HTTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_HTTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_HTTT = value;
		}
	}

	internal virtual TextBox txtNguoi_Gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNguoi_Gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNguoi_Gd = value;
		}
	}

	internal virtual TextBox txtMa_so_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_so_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_so_thue = value;
		}
	}

	internal virtual TextBox txtEmail
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtEmail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtEmail = value;
		}
	}

	internal virtual AsTextNumeric txtGh_No
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGh_No;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGh_No = value;
		}
	}

	internal virtual TextBox txtGhi_Chu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGhi_Chu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGhi_Chu = value;
		}
	}

	internal virtual TextBox txtHome_page
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHome_page;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtHome_page = value;
		}
	}

	internal virtual Label lblNguoi_Gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNguoi_Gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNguoi_Gd = value;
		}
	}

	internal virtual Label lblMa_So_Thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_So_Thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_So_Thue = value;
		}
	}

	internal virtual AsCheckBox chkIsNv
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkIsNv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkIsNv = value;
		}
	}

	internal virtual Label lblHome_page
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblHome_page;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblHome_page = value;
		}
	}

	internal virtual Label lblEmail
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblEmail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblEmail = value;
		}
	}

	internal virtual Label lblGh_No
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGh_No;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGh_No = value;
		}
	}

	internal virtual Label lblFax
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFax;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFax = value;
		}
	}

	internal virtual AsCheckBox chkIsNcc
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkIsNcc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkIsNcc = value;
		}
	}

	internal virtual Label lblTel
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTel = value;
		}
	}

	internal virtual Label lblGhi_Chu
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGhi_Chu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGhi_Chu = value;
		}
	}

	internal virtual AsCheckBox chkTinh_dt_nb
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkTinh_dt_nb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkTinh_dt_nb = value;
		}
	}

	internal virtual AsCheckBox chkIsKh
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkIsKh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkIsKh = value;
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

	internal virtual AsTextBox txtMA_HTTT_PO
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMA_HTTT_PO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMA_HTTT_PO = value;
		}
	}

	internal virtual Label lblTen_HTTT_PO
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_HTTT_PO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_HTTT_PO = value;
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

	internal virtual AsTextNumeric txtHan_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHan_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtHan_tt = value;
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

	internal virtual TextBox txtTinh_tp_nh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTinh_tp_nh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTinh_tp_nh = value;
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

	internal virtual TextBox txtCn_nh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCn_nh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCn_nh = value;
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

	internal virtual TextBox txtSo_tk_nh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_tk_nh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_tk_nh = value;
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

	internal virtual AsTextBox txtMa_Ngh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Ngh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Ngh = value;
		}
	}

	internal virtual Label lblTen_nh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nh = value;
		}
	}

	internal virtual AsTextBox txtMa_PlKh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_PlKh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_PlKh1 = value;
		}
	}

	internal virtual Label lblTen_Plkh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Plkh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Plkh1 = value;
		}
	}

	internal virtual AsTextBox txtMa_PlKh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_PlKh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_PlKh2 = value;
		}
	}

	internal virtual Label lblTen_Plkh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Plkh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Plkh2 = value;
		}
	}

	internal virtual AsTextBox txtMa_PlKh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_PlKh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_PlKh3 = value;
		}
	}

	internal virtual Label lblTen_Plkh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Plkh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Plkh3 = value;
		}
	}

	internal virtual Label lblMa_Plkh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Plkh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Plkh3 = value;
		}
	}

	internal virtual Label lblMa_Plkh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Plkh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Plkh1 = value;
		}
	}

	internal virtual Label lblMa_Plkh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Plkh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Plkh2 = value;
		}
	}

	[DebuggerNonUserCode]
	public frmARDMKHEdit()
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
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
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
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
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
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_1f50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5a: Expected O, but got Unknown
		//IL_2a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a40: Expected O, but got Unknown
		txtMa_Kh = new TextBox();
		txtTen_Kh = new TextBox();
		lbTen_KH = new Label();
		lbMa_KH = new Label();
		txtMA_HTTT_PO = new AsTextBox();
		lblTen_HTTT_PO = new Label();
		Label3 = new Label();
		lblGhi_Chu = new Label();
		Label2 = new Label();
		txtTel = new TextBox();
		txtFax = new TextBox();
		txtMA_HTTT = new AsTextBox();
		lblTen_HTTT = new Label();
		txtEmail = new TextBox();
		txtGh_No = new AsTextNumeric();
		txtGhi_Chu = new TextBox();
		txtNguoi_Gd = new TextBox();
		lblNguoi_Gd = new Label();
		txtHome_page = new TextBox();
		chkIsNv = new AsCheckBox();
		lblHome_page = new Label();
		lblEmail = new Label();
		lblGh_No = new Label();
		lblFax = new Label();
		chkIsNcc = new AsCheckBox();
		lblTel = new Label();
		chkTinh_dt_nb = new AsCheckBox();
		chkIsKh = new AsCheckBox();
		lblTK = new Label();
		lblDia_Chi = new Label();
		txtDia_chi = new TextBox();
		txtMa_so_thue = new TextBox();
		lblMa_So_Thue = new Label();
		txtHan_tt = new AsTextNumeric();
		Label1 = new Label();
		txtMa_Ngh = new AsTextBox();
		lblTen_nh = new Label();
		txtSo_tk_nh = new TextBox();
		Label5 = new Label();
		Label6 = new Label();
		txtCn_nh = new TextBox();
		Label7 = new Label();
		txtTinh_tp_nh = new TextBox();
		txtMa_PlKh1 = new AsTextBox();
		lblTen_Plkh1 = new Label();
		txtMa_PlKh2 = new AsTextBox();
		lblTen_Plkh2 = new Label();
		txtMa_PlKh3 = new AsTextBox();
		lblTen_Plkh3 = new Label();
		lblMa_Plkh3 = new Label();
		lblMa_Plkh1 = new Label();
		lblMa_Plkh2 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((Control)chkKsd).Anchor = (AnchorStyles)9;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(275, 483);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 25;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 519);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 519);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Anchor = (AnchorStyles)13;
		((Control)gbLine).Controls.Add((Control)(object)txtMa_PlKh1);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_PlKh2);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_PlKh3);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Plkh3);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Plkh1);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Plkh1);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Plkh2);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Plkh3);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Plkh2);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)txtTinh_tp_nh);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)txtCn_nh);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_tk_nh);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Ngh);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_nh);
		((Control)gbLine).Controls.Add((Control)(object)txtHan_tt);
		((Control)gbLine).Controls.Add((Control)(object)txtMA_HTTT_PO);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_HTTT_PO);
		((Control)gbLine).Controls.Add((Control)(object)lblDia_Chi);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)lbTen_KH);
		((Control)gbLine).Controls.Add((Control)(object)lblGhi_Chu);
		((Control)gbLine).Controls.Add((Control)(object)lbMa_KH);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Kh);
		((Control)gbLine).Controls.Add((Control)(object)txtTel);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Kh);
		((Control)gbLine).Controls.Add((Control)(object)txtFax);
		((Control)gbLine).Controls.Add((Control)(object)txtDia_chi);
		((Control)gbLine).Controls.Add((Control)(object)txtMA_HTTT);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_so_thue);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_So_Thue);
		((Control)gbLine).Controls.Add((Control)(object)txtEmail);
		((Control)gbLine).Controls.Add((Control)(object)txtGh_No);
		((Control)gbLine).Controls.Add((Control)(object)lblNguoi_Gd);
		((Control)gbLine).Controls.Add((Control)(object)txtGhi_Chu);
		((Control)gbLine).Controls.Add((Control)(object)lblTK);
		((Control)gbLine).Controls.Add((Control)(object)txtNguoi_Gd);
		((Control)gbLine).Controls.Add((Control)(object)txtHome_page);
		((Control)gbLine).Controls.Add((Control)(object)chkIsNv);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_HTTT);
		((Control)gbLine).Controls.Add((Control)(object)lblHome_page);
		((Control)gbLine).Controls.Add((Control)(object)chkIsKh);
		((Control)gbLine).Controls.Add((Control)(object)lblEmail);
		((Control)gbLine).Controls.Add((Control)(object)chkTinh_dt_nb);
		((Control)gbLine).Controls.Add((Control)(object)lblGh_No);
		((Control)gbLine).Controls.Add((Control)(object)lblTel);
		((Control)gbLine).Controls.Add((Control)(object)lblFax);
		((Control)gbLine).Controls.Add((Control)(object)chkIsNcc);
		GroupBox obj3 = gbLine;
		Size size = new Size(750, 506);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkIsNcc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblFax, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTel, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblGh_No, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkTinh_dt_nb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblEmail, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkIsKh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblHome_page, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_HTTT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkIsNv, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtHome_page, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNguoi_Gd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGhi_Chu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNguoi_Gd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGh_No, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtEmail, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_So_Thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_so_thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMA_HTTT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDia_chi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtFax, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTel, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lbMa_KH, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblGhi_Chu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lbTen_KH, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDia_Chi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_HTTT_PO, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMA_HTTT_PO, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtHan_tt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_nh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Ngh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_tk_nh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtCn_nh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTinh_tp_nh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Plkh2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Plkh3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Plkh2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Plkh1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Plkh1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Plkh3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_PlKh3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_PlKh2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_PlKh1, 0);
		txtMa_Kh.CharacterCasing = (CharacterCasing)1;
		TextBox obj4 = txtMa_Kh;
		location = new Point(126, 19);
		((Control)obj4).Location = location;
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		TextBox obj5 = txtMa_Kh;
		size = new Size(100, 20);
		((Control)obj5).Size = size;
		((Control)txtMa_Kh).TabIndex = 0;
		TextBox obj6 = txtTen_Kh;
		location = new Point(312, 19);
		((Control)obj6).Location = location;
		((Control)txtTen_Kh).Name = "txtTen_Kh";
		TextBox obj7 = txtTen_Kh;
		size = new Size(415, 20);
		((Control)obj7).Size = size;
		((Control)txtTen_Kh).TabIndex = 1;
		lbTen_KH.AutoSize = true;
		lbTen_KH.ImeMode = (ImeMode)0;
		Label obj8 = lbTen_KH;
		location = new Point(232, 23);
		((Control)obj8).Location = location;
		((Control)lbTen_KH).Name = "lbTen_KH";
		Label obj9 = lbTen_KH;
		size = new Size(59, 13);
		((Control)obj9).Size = size;
		((Control)lbTen_KH).TabIndex = 10;
		lbTen_KH.Text = "Tên khách";
		lbMa_KH.AutoSize = true;
		lbMa_KH.ImeMode = (ImeMode)0;
		Label obj10 = lbMa_KH;
		location = new Point(11, 23);
		((Control)obj10).Location = location;
		((Control)lbMa_KH).Name = "lbMa_KH";
		Label obj11 = lbMa_KH;
		size = new Size(55, 13);
		((Control)obj11).Size = size;
		((Control)lbMa_KH).TabIndex = 9;
		lbMa_KH.Text = "Mã khách";
		txtMA_HTTT_PO.AutoLookup = true;
		txtMA_HTTT_PO.AutoValid = true;
		((TextBoxBase)txtMA_HTTT_PO).BackColor = SystemColors.Info;
		((TextBox)txtMA_HTTT_PO).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMA_HTTT_PO;
		location = new Point(126, 344);
		((Control)asTextBox).Location = location;
		txtMA_HTTT_PO.LookupCodeName = "MA_HTTT_PO";
		txtMA_HTTT_PO.LookupWhereCondition = "moduleid='PO'";
		((Control)txtMA_HTTT_PO).Name = "txtMA_HTTT_PO";
		txtMA_HTTT_PO.NameControl = lblTen_HTTT_PO;
		txtMA_HTTT_PO.SD = true;
		AsTextBox asTextBox2 = txtMA_HTTT_PO;
		size = new Size(68, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMA_HTTT_PO).TabIndex = 17;
		((Control)txtMA_HTTT_PO).Tag = "";
		txtMA_HTTT_PO.UseAutoCompleteSource = true;
		lblTen_HTTT_PO.ImeMode = (ImeMode)0;
		Label obj12 = lblTen_HTTT_PO;
		location = new Point(200, 348);
		((Control)obj12).Location = location;
		((Control)lblTen_HTTT_PO).Name = "lblTen_HTTT_PO";
		Label obj13 = lblTen_HTTT_PO;
		size = new Size(436, 13);
		((Control)obj13).Size = size;
		((Control)lblTen_HTTT_PO).TabIndex = 217;
		lblTen_HTTT_PO.Text = "Tên HTTT";
		Label3.AutoSize = true;
		Label3.ImeMode = (ImeMode)0;
		Label label = Label3;
		location = new Point(11, 348);
		((Control)label).Location = location;
		((Control)Label3).Name = "Label3";
		Label label2 = Label3;
		size = new Size(99, 13);
		((Control)label2).Size = size;
		((Control)Label3).TabIndex = 216;
		Label3.Text = "Mã thanh toán mua";
		Label3.TextAlign = (ContentAlignment)16;
		((Control)lblGhi_Chu).Anchor = (AnchorStyles)9;
		lblGhi_Chu.AutoSize = true;
		lblGhi_Chu.ImeMode = (ImeMode)0;
		Label obj14 = lblGhi_Chu;
		location = new Point(277, 385);
		((Control)obj14).Location = location;
		((Control)lblGhi_Chu).Name = "lblGhi_Chu";
		Label obj15 = lblGhi_Chu;
		size = new Size(44, 13);
		((Control)obj15).Size = size;
		((Control)lblGhi_Chu).TabIndex = 22;
		lblGhi_Chu.Text = "Ghi chú";
		lblGhi_Chu.TextAlign = (ContentAlignment)16;
		Label2.AutoSize = true;
		Label2.ImeMode = (ImeMode)0;
		Label label3 = Label2;
		location = new Point(11, 369);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(81, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 213;
		Label2.Text = "Hạn thanh toán";
		Label2.TextAlign = (ContentAlignment)16;
		TextBox obj16 = txtTel;
		location = new Point(126, 85);
		((Control)obj16).Location = location;
		((Control)txtTel).Name = "txtTel";
		TextBox obj17 = txtTel;
		size = new Size(134, 20);
		((Control)obj17).Size = size;
		((Control)txtTel).TabIndex = 5;
		TextBox obj18 = txtFax;
		location = new Point(593, 85);
		((Control)obj18).Location = location;
		((Control)txtFax).Name = "txtFax";
		TextBox obj19 = txtFax;
		size = new Size(134, 20);
		((Control)obj19).Size = size;
		((Control)txtFax).TabIndex = 6;
		txtMA_HTTT.AutoLookup = true;
		txtMA_HTTT.AutoValid = true;
		((TextBoxBase)txtMA_HTTT).BackColor = SystemColors.Info;
		((TextBox)txtMA_HTTT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMA_HTTT;
		location = new Point(126, 322);
		((Control)asTextBox3).Location = location;
		txtMA_HTTT.LookupCodeName = "MA_HTTT";
		txtMA_HTTT.LookupWhereCondition = "moduleid='SO'";
		((Control)txtMA_HTTT).Name = "txtMA_HTTT";
		txtMA_HTTT.NameControl = lblTen_HTTT;
		txtMA_HTTT.SD = true;
		AsTextBox asTextBox4 = txtMA_HTTT;
		size = new Size(68, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMA_HTTT).TabIndex = 16;
		((Control)txtMA_HTTT).Tag = "";
		txtMA_HTTT.UseAutoCompleteSource = true;
		lblTen_HTTT.ImeMode = (ImeMode)0;
		Label obj20 = lblTen_HTTT;
		location = new Point(200, 326);
		((Control)obj20).Location = location;
		((Control)lblTen_HTTT).Name = "lblTen_HTTT";
		Label obj21 = lblTen_HTTT;
		size = new Size(436, 13);
		((Control)obj21).Size = size;
		((Control)lblTen_HTTT).TabIndex = 207;
		lblTen_HTTT.Text = "Tên HTTT";
		TextBox obj22 = txtEmail;
		location = new Point(126, 107);
		((Control)obj22).Location = location;
		((Control)txtEmail).Name = "txtEmail";
		TextBox obj23 = txtEmail;
		size = new Size(297, 20);
		((Control)obj23).Size = size;
		((Control)txtEmail).TabIndex = 7;
		txtGh_No.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtGh_No;
		location = new Point(627, 373);
		((Control)asTextNumeric).Location = location;
		txtGh_No.Mask = "999 999 999 999 999.99";
		((Control)txtGh_No).Name = "txtGh_No";
		AsTextNumeric asTextNumeric2 = txtGh_No;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtGh_No).TabIndex = 19;
		((TextBox)txtGh_No).Text = "0.00";
		((TextBox)txtGh_No).TextAlign = (HorizontalAlignment)1;
		txtGh_No.Value = 0.0;
		((Control)txtGhi_Chu).Anchor = (AnchorStyles)9;
		TextBox obj24 = txtGhi_Chu;
		location = new Point(275, 401);
		((Control)obj24).Location = location;
		txtGhi_Chu.Multiline = true;
		((Control)txtGhi_Chu).Name = "txtGhi_Chu";
		txtGhi_Chu.ScrollBars = (ScrollBars)1;
		TextBox obj25 = txtGhi_Chu;
		size = new Size(463, 78);
		((Control)obj25).Size = size;
		((Control)txtGhi_Chu).TabIndex = 24;
		((Control)txtGhi_Chu).TabStop = false;
		TextBox obj26 = txtNguoi_Gd;
		location = new Point(593, 63);
		((Control)obj26).Location = location;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		TextBox obj27 = txtNguoi_Gd;
		size = new Size(134, 20);
		((Control)obj27).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 4;
		lblNguoi_Gd.AutoSize = true;
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj28 = lblNguoi_Gd;
		location = new Point(487, 67);
		((Control)obj28).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj29 = lblNguoi_Gd;
		size = new Size(81, 13);
		((Control)obj29).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 12;
		lblNguoi_Gd.Text = "Người giao dịch";
		lblNguoi_Gd.TextAlign = (ContentAlignment)16;
		TextBox obj30 = txtHome_page;
		location = new Point(126, 129);
		((Control)obj30).Location = location;
		((Control)txtHome_page).Name = "txtHome_page";
		TextBox obj31 = txtHome_page;
		size = new Size(297, 20);
		((Control)obj31).Size = size;
		((Control)txtHome_page).TabIndex = 8;
		((ButtonBase)chkIsNv).AutoSize = true;
		chkIsNv.Checked = false;
		AsCheckBox asCheckBox2 = chkIsNv;
		location = new Point(126, 461);
		((Control)asCheckBox2).Location = location;
		((Control)chkIsNv).Name = "chkIsNv";
		AsCheckBox asCheckBox3 = chkIsNv;
		size = new Size(90, 17);
		((Control)asCheckBox3).Size = size;
		((Control)chkIsNv).TabIndex = 23;
		((Control)chkIsNv).TabStop = false;
		((ButtonBase)chkIsNv).Text = "Là Nhân viên";
		chkIsNv.TextValue = "0";
		((ButtonBase)chkIsNv).UseVisualStyleBackColor = true;
		lblHome_page.AutoSize = true;
		lblHome_page.ImeMode = (ImeMode)0;
		Label obj32 = lblHome_page;
		location = new Point(11, 133);
		((Control)obj32).Location = location;
		((Control)lblHome_page).Name = "lblHome_page";
		Label obj33 = lblHome_page;
		size = new Size(56, 13);
		((Control)obj33).Size = size;
		((Control)lblHome_page).TabIndex = 23;
		lblHome_page.Text = "Trang chủ";
		lblHome_page.TextAlign = (ContentAlignment)16;
		lblEmail.AutoSize = true;
		lblEmail.ImeMode = (ImeMode)0;
		Label obj34 = lblEmail;
		location = new Point(11, 111);
		((Control)obj34).Location = location;
		((Control)lblEmail).Name = "lblEmail";
		Label obj35 = lblEmail;
		size = new Size(32, 13);
		((Control)obj35).Size = size;
		((Control)lblEmail).TabIndex = 21;
		lblEmail.Text = "Email";
		lblEmail.TextAlign = (ContentAlignment)16;
		lblGh_No.AutoSize = true;
		lblGh_No.ImeMode = (ImeMode)0;
		Label obj36 = lblGh_No;
		location = new Point(523, 376);
		((Control)obj36).Location = location;
		((Control)lblGh_No).Name = "lblGh_No";
		Label obj37 = lblGh_No;
		size = new Size(61, 13);
		((Control)obj37).Size = size;
		((Control)lblGh_No).TabIndex = 39;
		lblGh_No.Text = "Giới hạn nợ";
		lblGh_No.TextAlign = (ContentAlignment)16;
		lblFax.AutoSize = true;
		lblFax.ImeMode = (ImeMode)0;
		Label obj38 = lblFax;
		location = new Point(488, 89);
		((Control)obj38).Location = location;
		((Control)lblFax).Name = "lblFax";
		Label obj39 = lblFax;
		size = new Size(24, 13);
		((Control)obj39).Size = size;
		((Control)lblFax).TabIndex = 12;
		lblFax.Text = "Fax";
		lblFax.TextAlign = (ContentAlignment)16;
		((ButtonBase)chkIsNcc).AutoSize = true;
		chkIsNcc.Checked = true;
		((CheckBox)chkIsNcc).CheckState = (CheckState)1;
		AsCheckBox asCheckBox4 = chkIsNcc;
		location = new Point(126, 437);
		((Control)asCheckBox4).Location = location;
		((Control)chkIsNcc).Name = "chkIsNcc";
		AsCheckBox asCheckBox5 = chkIsNcc;
		size = new Size(109, 17);
		((Control)asCheckBox5).Size = size;
		((Control)chkIsNcc).TabIndex = 22;
		((Control)chkIsNcc).TabStop = false;
		((ButtonBase)chkIsNcc).Text = "Là Nhà cung cấp";
		((ButtonBase)chkIsNcc).UseVisualStyleBackColor = true;
		lblTel.AutoSize = true;
		lblTel.ImeMode = (ImeMode)0;
		Label obj40 = lblTel;
		location = new Point(11, 89);
		((Control)obj40).Location = location;
		((Control)lblTel).Name = "lblTel";
		Label obj41 = lblTel;
		size = new Size(55, 13);
		((Control)obj41).Size = size;
		((Control)lblTel).TabIndex = 10;
		lblTel.Text = "Điện thoại";
		lblTel.TextAlign = (ContentAlignment)16;
		((ButtonBase)chkTinh_dt_nb).AutoSize = true;
		chkTinh_dt_nb.Checked = false;
		AsCheckBox asCheckBox6 = chkTinh_dt_nb;
		location = new Point(126, 390);
		((Control)asCheckBox6).Location = location;
		((Control)chkTinh_dt_nb).Name = "chkTinh_dt_nb";
		AsCheckBox asCheckBox7 = chkTinh_dt_nb;
		size = new Size(82, 17);
		((Control)asCheckBox7).Size = size;
		((Control)chkTinh_dt_nb).TabIndex = 20;
		((Control)chkTinh_dt_nb).TabStop = false;
		((ButtonBase)chkTinh_dt_nb).Text = "Tính DTNB";
		chkTinh_dt_nb.TextValue = "0";
		((ButtonBase)chkTinh_dt_nb).UseVisualStyleBackColor = true;
		((ButtonBase)chkIsKh).AutoSize = true;
		chkIsKh.Checked = true;
		((CheckBox)chkIsKh).CheckState = (CheckState)1;
		AsCheckBox asCheckBox8 = chkIsKh;
		location = new Point(126, 413);
		((Control)asCheckBox8).Location = location;
		((Control)chkIsKh).Name = "chkIsKh";
		AsCheckBox asCheckBox9 = chkIsKh;
		size = new Size(99, 17);
		((Control)asCheckBox9).Size = size;
		((Control)chkIsKh).TabIndex = 21;
		((Control)chkIsKh).TabStop = false;
		((ButtonBase)chkIsKh).Text = "Là Khách hàng";
		((ButtonBase)chkIsKh).UseVisualStyleBackColor = true;
		lblTK.AutoSize = true;
		lblTK.ImeMode = (ImeMode)0;
		Label obj42 = lblTK;
		location = new Point(11, 326);
		((Control)obj42).Location = location;
		((Control)lblTK).Name = "lblTK";
		Label obj43 = lblTK;
		size = new Size(97, 13);
		((Control)obj43).Size = size;
		((Control)lblTK).TabIndex = 16;
		lblTK.Text = "Mã thanh toán bán";
		lblTK.TextAlign = (ContentAlignment)16;
		lblDia_Chi.AutoSize = true;
		lblDia_Chi.ImeMode = (ImeMode)0;
		Label obj44 = lblDia_Chi;
		location = new Point(11, 45);
		((Control)obj44).Location = location;
		((Control)lblDia_Chi).Name = "lblDia_Chi";
		Label obj45 = lblDia_Chi;
		size = new Size(40, 13);
		((Control)obj45).Size = size;
		((Control)lblDia_Chi).TabIndex = 2;
		lblDia_Chi.Text = "Địa chỉ";
		lblDia_Chi.TextAlign = (ContentAlignment)16;
		TextBox obj46 = txtDia_chi;
		location = new Point(126, 41);
		((Control)obj46).Location = location;
		((Control)txtDia_chi).Name = "txtDia_chi";
		TextBox obj47 = txtDia_chi;
		size = new Size(601, 20);
		((Control)obj47).Size = size;
		((Control)txtDia_chi).TabIndex = 2;
		TextBox obj48 = txtMa_so_thue;
		location = new Point(126, 63);
		((Control)obj48).Location = location;
		((Control)txtMa_so_thue).Name = "txtMa_so_thue";
		TextBox obj49 = txtMa_so_thue;
		size = new Size(134, 20);
		((Control)obj49).Size = size;
		((Control)txtMa_so_thue).TabIndex = 3;
		lblMa_So_Thue.AutoSize = true;
		lblMa_So_Thue.ImeMode = (ImeMode)0;
		Label obj50 = lblMa_So_Thue;
		location = new Point(11, 67);
		((Control)obj50).Location = location;
		((Control)lblMa_So_Thue).Name = "lblMa_So_Thue";
		Label obj51 = lblMa_So_Thue;
		size = new Size(84, 13);
		((Control)obj51).Size = size;
		((Control)lblMa_So_Thue).TabIndex = 14;
		lblMa_So_Thue.Text = "Mã số thuế VAT";
		lblMa_So_Thue.TextAlign = (ContentAlignment)16;
		txtHan_tt.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric3 = txtHan_tt;
		location = new Point(126, 366);
		((Control)asTextNumeric3).Location = location;
		txtHan_tt.Mask = "999 999 999 999 999.99";
		((Control)txtHan_tt).Name = "txtHan_tt";
		AsTextNumeric asTextNumeric4 = txtHan_tt;
		size = new Size(68, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtHan_tt).TabIndex = 18;
		((TextBox)txtHan_tt).Text = "0.00";
		((TextBox)txtHan_tt).TextAlign = (HorizontalAlignment)1;
		txtHan_tt.Value = 0.0;
		Label1.AutoSize = true;
		((Control)Label1).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163);
		Label1.ImeMode = (ImeMode)0;
		Label label5 = Label1;
		location = new Point(11, 231);
		((Control)label5).Location = location;
		((Control)Label1).Name = "Label1";
		Label label6 = Label1;
		size = new Size(69, 13);
		((Control)label6).Size = size;
		((Control)Label1).TabIndex = 220;
		Label1.Text = "Ngân hàng";
		txtMa_Ngh.AutoLookup = true;
		txtMa_Ngh.AutoValid = true;
		((TextBoxBase)txtMa_Ngh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Ngh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_Ngh;
		location = new Point(148, 227);
		((Control)asTextBox5).Location = location;
		txtMa_Ngh.LookupCodeName = "MA_NGH";
		((Control)txtMa_Ngh).Name = "txtMa_Ngh";
		txtMa_Ngh.NameControl = lblTen_nh;
		txtMa_Ngh.SD = true;
		AsTextBox asTextBox6 = txtMa_Ngh;
		size = new Size(112, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_Ngh).TabIndex = 12;
		((Control)txtMa_Ngh).Tag = "";
		txtMa_Ngh.UseAutoCompleteSource = true;
		lblTen_nh.ImeMode = (ImeMode)0;
		Label obj52 = lblTen_nh;
		location = new Point(269, 230);
		((Control)obj52).Location = location;
		((Control)lblTen_nh).Name = "lblTen_nh";
		Label obj53 = lblTen_nh;
		size = new Size(340, 13);
		((Control)obj53).Size = size;
		((Control)lblTen_nh).TabIndex = 221;
		lblTen_nh.Text = "Tên ngân hàng";
		TextBox obj54 = txtSo_tk_nh;
		location = new Point(148, 249);
		((Control)obj54).Location = location;
		((Control)txtSo_tk_nh).Name = "txtSo_tk_nh";
		TextBox obj55 = txtSo_tk_nh;
		size = new Size(162, 20);
		((Control)obj55).Size = size;
		((Control)txtSo_tk_nh).TabIndex = 13;
		Label5.AutoSize = true;
		Label5.ImeMode = (ImeMode)0;
		Label label7 = Label5;
		location = new Point(36, 253);
		((Control)label7).Location = location;
		((Control)Label5).Name = "Label5";
		Label label8 = Label5;
		size = new Size(55, 13);
		((Control)label8).Size = size;
		((Control)Label5).TabIndex = 223;
		Label5.Text = "Tài khoản";
		Label5.TextAlign = (ContentAlignment)16;
		Label6.AutoSize = true;
		Label6.ImeMode = (ImeMode)0;
		Label label9 = Label6;
		location = new Point(36, 275);
		((Control)label9).Location = location;
		((Control)Label6).Name = "Label6";
		Label label10 = Label6;
		size = new Size(55, 13);
		((Control)label10).Size = size;
		((Control)Label6).TabIndex = 225;
		Label6.Text = "Chi nhánh";
		Label6.TextAlign = (ContentAlignment)16;
		TextBox obj56 = txtCn_nh;
		location = new Point(148, 271);
		((Control)obj56).Location = location;
		((Control)txtCn_nh).Name = "txtCn_nh";
		TextBox obj57 = txtCn_nh;
		size = new Size(278, 20);
		((Control)obj57).Size = size;
		((Control)txtCn_nh).TabIndex = 14;
		Label7.AutoSize = true;
		Label7.ImeMode = (ImeMode)0;
		Label label11 = Label7;
		location = new Point(36, 297);
		((Control)label11).Location = location;
		((Control)Label7).Name = "Label7";
		Label label12 = Label7;
		size = new Size(58, 13);
		((Control)label12).Size = size;
		((Control)Label7).TabIndex = 227;
		Label7.Text = "Tỉnh thành";
		Label7.TextAlign = (ContentAlignment)16;
		TextBox obj58 = txtTinh_tp_nh;
		location = new Point(148, 293);
		((Control)obj58).Location = location;
		((Control)txtTinh_tp_nh).Name = "txtTinh_tp_nh";
		TextBox obj59 = txtTinh_tp_nh;
		size = new Size(278, 20);
		((Control)obj59).Size = size;
		((Control)txtTinh_tp_nh).TabIndex = 15;
		txtMa_PlKh1.AutoLookup = true;
		txtMa_PlKh1.AutoValid = true;
		((TextBoxBase)txtMa_PlKh1).BackColor = SystemColors.Info;
		((TextBox)txtMa_PlKh1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_PlKh1;
		location = new Point(126, 152);
		((Control)asTextBox7).Location = location;
		txtMa_PlKh1.LookupCodeName = "MA_PLKH";
		txtMa_PlKh1.LookupWhereCondition = "loai=1";
		((TextBoxBase)txtMa_PlKh1).MaxLength = 8;
		((Control)txtMa_PlKh1).Name = "txtMa_PlKh1";
		txtMa_PlKh1.NameControl = lblTen_Plkh1;
		txtMa_PlKh1.SD = true;
		AsTextBox asTextBox8 = txtMa_PlKh1;
		size = new Size(68, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_PlKh1).TabIndex = 9;
		((Control)txtMa_PlKh1).Tag = "";
		txtMa_PlKh1.UseAutoCompleteSource = true;
		lblTen_Plkh1.ImeMode = (ImeMode)0;
		Label obj60 = lblTen_Plkh1;
		location = new Point(200, 155);
		((Control)obj60).Location = location;
		((Control)lblTen_Plkh1).Name = "lblTen_Plkh1";
		Label obj61 = lblTen_Plkh1;
		size = new Size(412, 13);
		((Control)obj61).Size = size;
		((Control)lblTen_Plkh1).TabIndex = 234;
		lblTen_Plkh1.Text = "Tên PLKH1";
		txtMa_PlKh2.AutoLookup = true;
		txtMa_PlKh2.AutoValid = true;
		((TextBoxBase)txtMa_PlKh2).BackColor = SystemColors.Info;
		((TextBox)txtMa_PlKh2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_PlKh2;
		location = new Point(126, 174);
		((Control)asTextBox9).Location = location;
		txtMa_PlKh2.LookupCodeName = "MA_PLKH";
		txtMa_PlKh2.LookupWhereCondition = "loai=2";
		((TextBoxBase)txtMa_PlKh2).MaxLength = 8;
		((Control)txtMa_PlKh2).Name = "txtMa_PlKh2";
		txtMa_PlKh2.NameControl = lblTen_Plkh2;
		txtMa_PlKh2.SD = true;
		AsTextBox asTextBox10 = txtMa_PlKh2;
		size = new Size(68, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_PlKh2).TabIndex = 10;
		((Control)txtMa_PlKh2).Tag = "MA_PLKH2";
		txtMa_PlKh2.UseAutoCompleteSource = true;
		lblTen_Plkh2.ImeMode = (ImeMode)0;
		Label obj62 = lblTen_Plkh2;
		location = new Point(200, 177);
		((Control)obj62).Location = location;
		((Control)lblTen_Plkh2).Name = "lblTen_Plkh2";
		Label obj63 = lblTen_Plkh2;
		size = new Size(412, 13);
		((Control)obj63).Size = size;
		((Control)lblTen_Plkh2).TabIndex = 235;
		lblTen_Plkh2.Text = "Tên PLKH2";
		txtMa_PlKh3.AutoLookup = true;
		txtMa_PlKh3.AutoValid = true;
		((TextBoxBase)txtMa_PlKh3).BackColor = SystemColors.Info;
		((TextBox)txtMa_PlKh3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtMa_PlKh3;
		location = new Point(126, 196);
		((Control)asTextBox11).Location = location;
		txtMa_PlKh3.LookupCodeName = "MA_PLKH";
		txtMa_PlKh3.LookupWhereCondition = "loai=3";
		((TextBoxBase)txtMa_PlKh3).MaxLength = 8;
		((Control)txtMa_PlKh3).Name = "txtMa_PlKh3";
		txtMa_PlKh3.NameControl = lblTen_Plkh3;
		txtMa_PlKh3.SD = true;
		AsTextBox asTextBox12 = txtMa_PlKh3;
		size = new Size(68, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtMa_PlKh3).TabIndex = 11;
		((Control)txtMa_PlKh3).Tag = "MA_PLKH3";
		txtMa_PlKh3.UseAutoCompleteSource = true;
		lblTen_Plkh3.ImeMode = (ImeMode)0;
		Label obj64 = lblTen_Plkh3;
		location = new Point(200, 199);
		((Control)obj64).Location = location;
		((Control)lblTen_Plkh3).Name = "lblTen_Plkh3";
		Label obj65 = lblTen_Plkh3;
		size = new Size(412, 13);
		((Control)obj65).Size = size;
		((Control)lblTen_Plkh3).TabIndex = 236;
		lblTen_Plkh3.Text = "Tên PLKH3";
		lblMa_Plkh3.AutoSize = true;
		lblMa_Plkh3.ImeMode = (ImeMode)0;
		Label obj66 = lblMa_Plkh3;
		location = new Point(11, 199);
		((Control)obj66).Location = location;
		((Control)lblMa_Plkh3).Name = "lblMa_Plkh3";
		Label obj67 = lblMa_Plkh3;
		size = new Size(60, 13);
		((Control)obj67).Size = size;
		((Control)lblMa_Plkh3).TabIndex = 233;
		lblMa_Plkh3.Text = "Phân loại 3";
		lblMa_Plkh3.TextAlign = (ContentAlignment)16;
		lblMa_Plkh1.AutoSize = true;
		lblMa_Plkh1.ImeMode = (ImeMode)0;
		Label obj68 = lblMa_Plkh1;
		location = new Point(11, 155);
		((Control)obj68).Location = location;
		((Control)lblMa_Plkh1).Name = "lblMa_Plkh1";
		Label obj69 = lblMa_Plkh1;
		size = new Size(60, 13);
		((Control)obj69).Size = size;
		((Control)lblMa_Plkh1).TabIndex = 231;
		lblMa_Plkh1.Text = "Phân loại 1";
		lblMa_Plkh1.TextAlign = (ContentAlignment)16;
		lblMa_Plkh2.AutoSize = true;
		lblMa_Plkh2.ImeMode = (ImeMode)0;
		Label obj70 = lblMa_Plkh2;
		location = new Point(11, 177);
		((Control)obj70).Location = location;
		((Control)lblMa_Plkh2).Name = "lblMa_Plkh2";
		Label obj71 = lblMa_Plkh2;
		size = new Size(60, 13);
		((Control)obj71).Size = size;
		((Control)lblMa_Plkh2).TabIndex = 232;
		lblMa_Plkh2.Text = "Phân loại 2";
		lblMa_Plkh2.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(775, 554);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		((Control)this).Name = "frmARDMKHEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_Kh).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_Kh).Select();
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		string text = Conversions.ToString(Helper.Repl_Null(base.MyMenuInfo.moduleid, isNum: false));
		if (!EditMode)
		{
			switch (text)
			{
			case "CA":
				chkIsNv.Checked = true;
				break;
			case "AR":
				chkIsKh.Checked = true;
				break;
			case "AP":
				chkIsNcc.Checked = true;
				break;
			}
		}
		txtMA_HTTT.MyValid();
		txtMA_HTTT_PO.MyValid();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected O, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_Kh;
		CreateDataBinding(ref ojb, "ma_kh");
		txtMa_Kh = (TextBox)ojb;
		ojb = (Control)(object)txtTen_Kh;
		CreateDataBinding(ref ojb, "ten_kh");
		txtTen_Kh = (TextBox)ojb;
		ojb = (Control)(object)txtMa_PlKh1;
		CreateDataBinding(ref ojb, "ma_plkh1");
		txtMa_PlKh1 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_Plkh1;
		CreateDataBinding(ref ojb, "ten_plkh1");
		lblTen_Plkh1 = (Label)ojb;
		ojb = (Control)(object)txtMa_PlKh2;
		CreateDataBinding(ref ojb, "ma_plkh2");
		txtMa_PlKh2 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_Plkh2;
		CreateDataBinding(ref ojb, "ten_plkh2");
		lblTen_Plkh2 = (Label)ojb;
		ojb = (Control)(object)txtMa_PlKh3;
		CreateDataBinding(ref ojb, "ma_plkh3");
		txtMa_PlKh3 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_Plkh3;
		CreateDataBinding(ref ojb, "ten_plkh3");
		lblTen_Plkh3 = (Label)ojb;
		ojb = (Control)(object)txtDia_chi;
		CreateDataBinding(ref ojb, "dia_chi");
		txtDia_chi = (TextBox)ojb;
		ojb = (Control)(object)txtEmail;
		CreateDataBinding(ref ojb, "email");
		txtEmail = (TextBox)ojb;
		ojb = (Control)(object)txtFax;
		CreateDataBinding(ref ojb, "fax");
		txtFax = (TextBox)ojb;
		ojb = (Control)(object)txtGh_No;
		CreateDataBinding(ref ojb, "gh_no", "Value");
		txtGh_No = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtHan_tt;
		CreateDataBinding(ref ojb, "han_tt", "Value");
		txtHan_tt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtMa_Ngh;
		CreateDataBinding(ref ojb, "ma_ngh");
		txtMa_Ngh = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_nh;
		CreateDataBinding(ref ojb, "ten_nh");
		lblTen_nh = (Label)ojb;
		ojb = (Control)(object)txtSo_tk_nh;
		CreateDataBinding(ref ojb, "so_tk_nh");
		txtSo_tk_nh = (TextBox)ojb;
		ojb = (Control)(object)txtCn_nh;
		CreateDataBinding(ref ojb, "Cn_nh");
		txtCn_nh = (TextBox)ojb;
		ojb = (Control)(object)txtTinh_tp_nh;
		CreateDataBinding(ref ojb, "tinh_tp_nh");
		txtTinh_tp_nh = (TextBox)ojb;
		ojb = (Control)(object)txtHome_page;
		CreateDataBinding(ref ojb, "home_page");
		txtHome_page = (TextBox)ojb;
		ojb = (Control)(object)txtMa_so_thue;
		CreateDataBinding(ref ojb, "ma_so_thue");
		txtMa_so_thue = (TextBox)ojb;
		ojb = (Control)(object)txtNguoi_Gd;
		CreateDataBinding(ref ojb, "nguoi_gd");
		txtNguoi_Gd = (TextBox)ojb;
		ojb = (Control)(object)txtTel;
		CreateDataBinding(ref ojb, "tel");
		txtTel = (TextBox)ojb;
		ojb = (Control)(object)txtMA_HTTT;
		CreateDataBinding(ref ojb, "MA_HTTT");
		txtMA_HTTT = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMA_HTTT_PO;
		CreateDataBinding(ref ojb, "MA_HTTT_PO");
		txtMA_HTTT_PO = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_HTTT;
		CreateDataBinding(ref ojb, "ten_httt");
		lblTen_HTTT = (Label)ojb;
		ojb = (Control)(object)lblTen_HTTT_PO;
		CreateDataBinding(ref ojb, "ten_httt_po");
		lblTen_HTTT_PO = (Label)ojb;
		ojb = (Control)(object)txtGhi_Chu;
		CreateDataBinding(ref ojb, "ghi_chu");
		txtGhi_Chu = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkTinh_dt_nb;
		CreateDataBinding(ref ojb, "tinh_dt_nb", "Checked");
		chkTinh_dt_nb = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkIsKh;
		CreateDataBinding(ref ojb, "iskh", "Checked");
		chkIsKh = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkIsNcc;
		CreateDataBinding(ref ojb, "isncc", "Checked");
		chkIsNcc = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkIsNv;
		CreateDataBinding(ref ojb, "isnv", "Checked");
		chkIsNv = (AsCheckBox)(object)ojb;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_Kh).Enabled = false;
		((Control)txtTen_Kh).Select();
	}

	protected override bool ValidData()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		if (!ChkEmtyTextBox(txtMa_Kh) || !ChkEmtyTextBox(txtTen_Kh))
		{
			return false;
		}
		if (((int)((CheckBox)chkIsKh).CheckState == 0 && (int)((CheckBox)chkIsNcc).CheckState == 0 && (int)((CheckBox)chkIsNv).CheckState == 0) ? true : false)
		{
			((Control)chkIsKh).Select();
			SetControlError((Control)(object)chkIsKh, Helper.GetMessContent(50102));
			return false;
		}
		return base.ValidData();
	}
}
