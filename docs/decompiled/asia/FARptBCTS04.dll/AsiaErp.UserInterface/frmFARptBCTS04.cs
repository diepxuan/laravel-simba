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
public class frmFARptBCTS04 : frmReport
{
	internal class GroupItem
	{
		private string mtext;

		private string mvalue;

		public object Text
		{
			get
			{
				return mtext;
			}
			set
			{
				mtext = Conversions.ToString(value);
			}
		}

		public object Value
		{
			get
			{
				return mvalue;
			}
			set
			{
				mvalue = Conversions.ToString(value);
			}
		}

		public GroupItem(string value, string text)
		{
			mtext = text;
			mvalue = value;
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_BPSD")]
	private AsTextBox _txtMa_BPSD;

	[AccessedThroughProperty("lblTen_BPSD")]
	private Label _lblTen_BPSD;

	[AccessedThroughProperty("lblMa_BPSD")]
	private Label _lblMa_BPSD;

	[AccessedThroughProperty("txtMa_ts")]
	private AsTextBox _txtMa_ts;

	[AccessedThroughProperty("lblMa_ts")]
	private Label _lblMa_ts;

	[AccessedThroughProperty("txtMa_Nhts1")]
	private AsTextBox _txtMa_Nhts1;

	[AccessedThroughProperty("lblTen_Nhts1")]
	private Label _lblTen_Nhts1;

	[AccessedThroughProperty("lblMa_Nhts1")]
	private Label _lblMa_Nhts1;

	[AccessedThroughProperty("txtMa_Nhts3")]
	private AsTextBox _txtMa_Nhts3;

	[AccessedThroughProperty("lblTen_Nhts3")]
	private Label _lblTen_Nhts3;

	[AccessedThroughProperty("lblMa_Nhts3")]
	private Label _lblMa_Nhts3;

	[AccessedThroughProperty("txtMa_Phi")]
	private AsTextBox _txtMa_Phi;

	[AccessedThroughProperty("lblTen_Phi")]
	private Label _lblTen_Phi;

	[AccessedThroughProperty("lblMa_Phi")]
	private Label _lblMa_Phi;

	[AccessedThroughProperty("lblMa_SPCT")]
	private Label _lblMa_SPCT;

	[AccessedThroughProperty("txtMa_SPCT")]
	private AsTextBox _txtMa_SPCT;

	[AccessedThroughProperty("lblTen_SPCT")]
	private Label _lblTen_SPCT;

	[AccessedThroughProperty("txtMa_Nhts2")]
	private AsTextBox _txtMa_Nhts2;

	[AccessedThroughProperty("lblTen_Nhts2")]
	private Label _lblTen_Nhts2;

	[AccessedThroughProperty("lblMa_Nhts2")]
	private Label _lblMa_Nhts2;

	[AccessedThroughProperty("lblTen_ts")]
	private Label _lblTen_ts;

	[AccessedThroughProperty("cboNhom_cap1")]
	private AsComboBox _cboNhom_cap1;

	[AccessedThroughProperty("lblNhom_cap3")]
	private Label _lblNhom_cap3;

	[AccessedThroughProperty("cboNhom_cap3")]
	private AsComboBox _cboNhom_cap3;

	[AccessedThroughProperty("lblNhom_cap2")]
	private Label _lblNhom_cap2;

	[AccessedThroughProperty("cboNhom_cap2")]
	private AsComboBox _cboNhom_cap2;

	[AccessedThroughProperty("lblNhom_cap1")]
	private Label _lblNhom_cap1;

	private object[] ar;

	private string cap1;

	private string cap2;

	private string cap3;

	internal virtual AsTextBox txtMa_BPSD
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_BPSD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_BPSD = value;
		}
	}

	internal virtual Label lblTen_BPSD
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_BPSD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_BPSD = value;
		}
	}

	internal virtual Label lblMa_BPSD
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_BPSD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_BPSD = value;
		}
	}

	internal virtual AsTextBox txtMa_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_ts = value;
		}
	}

	internal virtual Label lblMa_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_ts = value;
		}
	}

	internal virtual AsTextBox txtMa_Nhts1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Nhts1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Nhts1 = value;
		}
	}

	internal virtual Label lblTen_Nhts1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Nhts1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Nhts1 = value;
		}
	}

	internal virtual Label lblMa_Nhts1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nhts1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nhts1 = value;
		}
	}

	internal virtual AsTextBox txtMa_Nhts3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Nhts3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Nhts3 = value;
		}
	}

	internal virtual Label lblTen_Nhts3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Nhts3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Nhts3 = value;
		}
	}

	internal virtual Label lblMa_Nhts3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nhts3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nhts3 = value;
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

	internal virtual Label lblTen_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Phi = value;
		}
	}

	internal virtual Label lblMa_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Phi = value;
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

	internal virtual AsTextBox txtMa_SPCT
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

	internal virtual Label lblTen_SPCT
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

	internal virtual AsTextBox txtMa_Nhts2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Nhts2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Nhts2 = value;
		}
	}

	internal virtual Label lblTen_Nhts2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Nhts2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Nhts2 = value;
		}
	}

	internal virtual Label lblMa_Nhts2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nhts2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nhts2 = value;
		}
	}

	internal virtual Label lblTen_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_ts = value;
		}
	}

	internal virtual AsComboBox cboNhom_cap1
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboNhom_cap1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboNhom_cap1_SelectedIndexChanged;
			if (_cboNhom_cap1 != null)
			{
				((ComboBox)_cboNhom_cap1).SelectedIndexChanged -= eventHandler;
			}
			_cboNhom_cap1 = value;
			if (_cboNhom_cap1 != null)
			{
				((ComboBox)_cboNhom_cap1).SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblNhom_cap3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNhom_cap3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNhom_cap3 = value;
		}
	}

	internal virtual AsComboBox cboNhom_cap3
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboNhom_cap3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboNhom_cap3_SelectedIndexChanged;
			if (_cboNhom_cap3 != null)
			{
				((ComboBox)_cboNhom_cap3).SelectedIndexChanged -= eventHandler;
			}
			_cboNhom_cap3 = value;
			if (_cboNhom_cap3 != null)
			{
				((ComboBox)_cboNhom_cap3).SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblNhom_cap2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNhom_cap2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNhom_cap2 = value;
		}
	}

	internal virtual AsComboBox cboNhom_cap2
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboNhom_cap2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboNhom_cap2_SelectedIndexChanged;
			if (_cboNhom_cap2 != null)
			{
				((ComboBox)_cboNhom_cap2).SelectedIndexChanged -= eventHandler;
			}
			_cboNhom_cap2 = value;
			if (_cboNhom_cap2 != null)
			{
				((ComboBox)_cboNhom_cap2).SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblNhom_cap1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNhom_cap1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNhom_cap1 = value;
		}
	}

	public frmFARptBCTS04(ref string MenuId)
		: base(MenuId)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		ar = new object[7];
		cap1 = "";
		cap2 = "";
		cap3 = "";
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
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		txtMa_BPSD = new AsTextBox();
		lblTen_BPSD = new Label();
		lblMa_BPSD = new Label();
		txtMa_ts = new AsTextBox();
		lblTen_ts = new Label();
		lblMa_ts = new Label();
		txtMa_Nhts1 = new AsTextBox();
		lblTen_Nhts1 = new Label();
		lblMa_Nhts1 = new Label();
		txtMa_Nhts3 = new AsTextBox();
		lblTen_Nhts3 = new Label();
		lblMa_Nhts3 = new Label();
		txtMa_Phi = new AsTextBox();
		lblTen_Phi = new Label();
		lblMa_Phi = new Label();
		lblMa_SPCT = new Label();
		txtMa_SPCT = new AsTextBox();
		lblTen_SPCT = new Label();
		txtMa_Nhts2 = new AsTextBox();
		lblTen_Nhts2 = new Label();
		lblMa_Nhts2 = new Label();
		cboNhom_cap1 = new AsComboBox();
		lblNhom_cap3 = new Label();
		cboNhom_cap3 = new AsComboBox();
		lblNhom_cap2 = new Label();
		cboNhom_cap2 = new AsComboBox();
		lblNhom_cap1 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(689, 500);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom_cap1);
		((Control)tabFilter).Controls.Add((Control)(object)lblNhom_cap3);
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom_cap3);
		((Control)tabFilter).Controls.Add((Control)(object)lblNhom_cap2);
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom_cap2);
		((Control)tabFilter).Controls.Add((Control)(object)lblNhom_cap1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_ts);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_BPSD);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_BPSD);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_BPSD);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_ts);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_ts);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Nhts1);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Nhts1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Nhts1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Nhts3);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Nhts3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Nhts3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_SPCT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_SPCT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_SPCT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Nhts2);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Nhts2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Nhts2);
		TabPage obj = tabFilter;
		size = new Size(681, 471);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Nhts2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Nhts2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nhts2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_SPCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_SPCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_SPCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Nhts3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Nhts3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nhts3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Nhts1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Nhts1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nhts1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_ts, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_ts, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_BPSD, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_BPSD, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_BPSD, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_ts, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNhom_cap1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom_cap2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNhom_cap2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom_cap3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNhom_cap3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom_cap1, 0);
		Label obj2 = lbl2;
		Point location = new Point(295, 82);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 17;
		((Control)cmdExcel).Anchor = (AnchorStyles)10;
		Button obj3 = cmdExcel;
		location = new Point(599, 448);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 16;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(316, 78);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		((Control)cmdCancel).Anchor = (AnchorStyles)10;
		Button obj4 = cmdCancel;
		location = new Point(518, 448);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 15;
		Button obj5 = cmdModifyReport;
		location = new Point(467, 24);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 11;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(225, 78);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(122, 78);
		((Control)obj6).Location = location;
		ComboBox obj7 = cboKyBc;
		size = new Size(87, 21);
		((Control)obj7).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		ComboBox obj8 = cboMau_bc;
		location = new Point(122, 25);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 11;
		Label obj9 = lblMau_bc;
		location = new Point(24, 29);
		((Control)obj9).Location = location;
		((Control)lblMau_bc).TabIndex = 22;
		((Control)txtMa_Nt).Enabled = false;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(344, 416);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 13;
		((Control)txtMa_Nt).Visible = false;
		((Control)lblMauBC).Enabled = false;
		Label obj10 = lblMauBC;
		location = new Point(389, 415);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 14;
		((Control)lblMauBC).Visible = false;
		((Control)optVND).Enabled = false;
		RadioButton obj11 = optVND;
		location = new Point(476, 414);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 15;
		((Control)optVND).Visible = false;
		((Control)optNt).Enabled = false;
		RadioButton obj12 = optNt;
		location = new Point(530, 415);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 16;
		((Control)optNt).Visible = false;
		((Control)lblMa_nt).Enabled = false;
		Label obj13 = lblMa_nt;
		location = new Point(258, 418);
		((Control)obj13).Location = location;
		((Control)lblMa_nt).TabIndex = 12;
		((Control)lblMa_nt).Visible = false;
		Button obj14 = cmdOk;
		location = new Point(17, 363);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 10;
		((Control)lblTieu_de).TabIndex = 23;
		TextBox obj15 = txtTieu_De;
		location = new Point(122, 52);
		((Control)obj15).Location = location;
		((Control)txtTieu_De).TabIndex = 12;
		TabPage obj16 = tabGrid;
		size = new Size(681, 471);
		((Control)obj16).Size = size;
		txtMa_BPSD.AutoLookup = true;
		txtMa_BPSD.AutoValid = false;
		((TextBoxBase)txtMa_BPSD).BackColor = SystemColors.Info;
		((TextBox)txtMa_BPSD).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_BPSD;
		location = new Point(122, 203);
		((Control)asTextBox2).Location = location;
		txtMa_BPSD.LookupCodeName = "MA_BPSD";
		((TextBoxBase)txtMa_BPSD).MaxLength = 8;
		((Control)txtMa_BPSD).Name = "txtMa_BPSD";
		txtMa_BPSD.NameControl = lblTen_BPSD;
		AsTextBox asTextBox3 = txtMa_BPSD;
		size = new Size(87, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_BPSD).TabIndex = 7;
		txtMa_BPSD.UseAutoCompleteSource = true;
		((Control)lblTen_BPSD).BackColor = Color.Transparent;
		Label obj17 = lblTen_BPSD;
		location = new Point(225, 207);
		((Control)obj17).Location = location;
		((Control)lblTen_BPSD).Name = "lblTen_BPSD";
		Label obj18 = lblTen_BPSD;
		size = new Size(317, 13);
		((Control)obj18).Size = size;
		((Control)lblTen_BPSD).TabIndex = 1342;
		lblMa_BPSD.AutoSize = true;
		Label obj19 = lblMa_BPSD;
		location = new Point(24, 207);
		((Control)obj19).Location = location;
		((Control)lblMa_BPSD).Name = "lblMa_BPSD";
		Label obj20 = lblMa_BPSD;
		size = new Size(54, 13);
		((Control)obj20).Size = size;
		((Control)lblMa_BPSD).TabIndex = 1341;
		lblMa_BPSD.Text = "Mã BPSD";
		txtMa_ts.AutoLookup = true;
		txtMa_ts.AutoValid = false;
		((TextBoxBase)txtMa_ts).BackColor = SystemColors.Info;
		((TextBox)txtMa_ts).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_ts;
		location = new Point(122, 104);
		((Control)asTextBox4).Location = location;
		txtMa_ts.LookupCodeName = "MA_TS";
		((TextBoxBase)txtMa_ts).MaxLength = 8;
		((Control)txtMa_ts).Name = "txtMa_ts";
		txtMa_ts.NameControl = lblTen_ts;
		AsTextBox asTextBox5 = txtMa_ts;
		size = new Size(87, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_ts).TabIndex = 3;
		txtMa_ts.UseAutoCompleteSource = true;
		((Control)lblTen_ts).BackColor = Color.Transparent;
		Label obj21 = lblTen_ts;
		location = new Point(225, 108);
		((Control)obj21).Location = location;
		((Control)lblTen_ts).Name = "lblTen_ts";
		Label obj22 = lblTen_ts;
		size = new Size(317, 13);
		((Control)obj22).Size = size;
		((Control)lblTen_ts).TabIndex = 1343;
		lblMa_ts.AutoSize = true;
		Label obj23 = lblMa_ts;
		location = new Point(24, 108);
		((Control)obj23).Location = location;
		((Control)lblMa_ts).Name = "lblMa_ts";
		Label obj24 = lblMa_ts;
		size = new Size(39, 13);
		((Control)obj24).Size = size;
		((Control)lblMa_ts).TabIndex = 1339;
		lblMa_ts.Text = "Mã TS";
		txtMa_Nhts1.AutoLookup = true;
		txtMa_Nhts1.AutoValid = false;
		((TextBoxBase)txtMa_Nhts1).BackColor = SystemColors.Info;
		((TextBox)txtMa_Nhts1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_Nhts1;
		location = new Point(122, 129);
		((Control)asTextBox6).Location = location;
		txtMa_Nhts1.LookupCodeName = "MA_NHTS";
		txtMa_Nhts1.LookupWhereCondition = "loai_nh=1";
		((TextBoxBase)txtMa_Nhts1).MaxLength = 8;
		((Control)txtMa_Nhts1).Name = "txtMa_Nhts1";
		txtMa_Nhts1.NameControl = lblTen_Nhts1;
		AsTextBox asTextBox7 = txtMa_Nhts1;
		size = new Size(87, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_Nhts1).TabIndex = 4;
		txtMa_Nhts1.UseAutoCompleteSource = true;
		((Control)lblTen_Nhts1).BackColor = Color.Transparent;
		Label obj25 = lblTen_Nhts1;
		location = new Point(225, 133);
		((Control)obj25).Location = location;
		((Control)lblTen_Nhts1).Name = "lblTen_Nhts1";
		Label obj26 = lblTen_Nhts1;
		size = new Size(317, 13);
		((Control)obj26).Size = size;
		((Control)lblTen_Nhts1).TabIndex = 1340;
		lblMa_Nhts1.AutoSize = true;
		Label obj27 = lblMa_Nhts1;
		location = new Point(24, 133);
		((Control)obj27).Location = location;
		((Control)lblMa_Nhts1).Name = "lblMa_Nhts1";
		Label obj28 = lblMa_Nhts1;
		size = new Size(74, 13);
		((Control)obj28).Size = size;
		((Control)lblMa_Nhts1).TabIndex = 1338;
		lblMa_Nhts1.Text = "Mã nhóm TS1";
		txtMa_Nhts3.AutoLookup = true;
		txtMa_Nhts3.AutoValid = false;
		((TextBoxBase)txtMa_Nhts3).BackColor = SystemColors.Info;
		((TextBox)txtMa_Nhts3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_Nhts3;
		location = new Point(122, 179);
		((Control)asTextBox8).Location = location;
		txtMa_Nhts3.LookupCodeName = "MA_NHTS";
		txtMa_Nhts3.LookupWhereCondition = "loai_nh=3";
		((TextBoxBase)txtMa_Nhts3).MaxLength = 8;
		((Control)txtMa_Nhts3).Name = "txtMa_Nhts3";
		txtMa_Nhts3.NameControl = lblTen_Nhts3;
		AsTextBox asTextBox9 = txtMa_Nhts3;
		size = new Size(87, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_Nhts3).TabIndex = 6;
		txtMa_Nhts3.UseAutoCompleteSource = true;
		((Control)lblTen_Nhts3).BackColor = Color.Transparent;
		Label obj29 = lblTen_Nhts3;
		location = new Point(225, 183);
		((Control)obj29).Location = location;
		((Control)lblTen_Nhts3).Name = "lblTen_Nhts3";
		Label obj30 = lblTen_Nhts3;
		size = new Size(317, 13);
		((Control)obj30).Size = size;
		((Control)lblTen_Nhts3).TabIndex = 1337;
		lblMa_Nhts3.AutoSize = true;
		Label obj31 = lblMa_Nhts3;
		location = new Point(24, 183);
		((Control)obj31).Location = location;
		((Control)lblMa_Nhts3).Name = "lblMa_Nhts3";
		Label obj32 = lblMa_Nhts3;
		size = new Size(74, 13);
		((Control)obj32).Size = size;
		((Control)lblMa_Nhts3).TabIndex = 1334;
		lblMa_Nhts3.Text = "Mã nhóm TS3";
		txtMa_Phi.AutoLookup = true;
		txtMa_Phi.AutoValid = false;
		((TextBoxBase)txtMa_Phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_Phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_Phi;
		location = new Point(122, 227);
		((Control)asTextBox10).Location = location;
		txtMa_Phi.LookupCodeName = "MA_PHI";
		((TextBoxBase)txtMa_Phi).MaxLength = 8;
		((Control)txtMa_Phi).Name = "txtMa_Phi";
		txtMa_Phi.NameControl = lblTen_Phi;
		AsTextBox asTextBox11 = txtMa_Phi;
		size = new Size(87, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_Phi).TabIndex = 8;
		txtMa_Phi.UseAutoCompleteSource = true;
		((Control)lblTen_Phi).BackColor = Color.Transparent;
		Label obj33 = lblTen_Phi;
		location = new Point(225, 231);
		((Control)obj33).Location = location;
		((Control)lblTen_Phi).Name = "lblTen_Phi";
		Label obj34 = lblTen_Phi;
		size = new Size(317, 13);
		((Control)obj34).Size = size;
		((Control)lblTen_Phi).TabIndex = 1336;
		lblMa_Phi.AutoSize = true;
		Label obj35 = lblMa_Phi;
		location = new Point(24, 231);
		((Control)obj35).Location = location;
		((Control)lblMa_Phi).Name = "lblMa_Phi";
		Label obj36 = lblMa_Phi;
		size = new Size(41, 13);
		((Control)obj36).Size = size;
		((Control)lblMa_Phi).TabIndex = 1335;
		lblMa_Phi.Text = "Mã phí";
		lblMa_SPCT.AutoSize = true;
		Label obj37 = lblMa_SPCT;
		location = new Point(24, 255);
		((Control)obj37).Location = location;
		((Control)lblMa_SPCT).Name = "lblMa_SPCT";
		Label obj38 = lblMa_SPCT;
		size = new Size(53, 13);
		((Control)obj38).Size = size;
		((Control)lblMa_SPCT).TabIndex = 1332;
		lblMa_SPCT.Text = "Mã SPCT";
		txtMa_SPCT.AutoLookup = true;
		txtMa_SPCT.AutoValid = false;
		((TextBoxBase)txtMa_SPCT).BackColor = SystemColors.Info;
		((TextBox)txtMa_SPCT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_SPCT;
		location = new Point(122, 251);
		((Control)asTextBox12).Location = location;
		txtMa_SPCT.LookupCodeName = "MA_SPCT";
		((TextBoxBase)txtMa_SPCT).MaxLength = 8;
		((Control)txtMa_SPCT).Name = "txtMa_SPCT";
		txtMa_SPCT.NameControl = lblTen_SPCT;
		AsTextBox asTextBox13 = txtMa_SPCT;
		size = new Size(87, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_SPCT).TabIndex = 9;
		txtMa_SPCT.UseAutoCompleteSource = true;
		((Control)lblTen_SPCT).BackColor = Color.Transparent;
		Label obj39 = lblTen_SPCT;
		location = new Point(225, 255);
		((Control)obj39).Location = location;
		((Control)lblTen_SPCT).Name = "lblTen_SPCT";
		Label obj40 = lblTen_SPCT;
		size = new Size(317, 13);
		((Control)obj40).Size = size;
		((Control)lblTen_SPCT).TabIndex = 1333;
		txtMa_Nhts2.AutoLookup = true;
		txtMa_Nhts2.AutoValid = false;
		((TextBoxBase)txtMa_Nhts2).BackColor = SystemColors.Info;
		((TextBox)txtMa_Nhts2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtMa_Nhts2;
		location = new Point(122, 154);
		((Control)asTextBox14).Location = location;
		txtMa_Nhts2.LookupCodeName = "MA_NHTS";
		txtMa_Nhts2.LookupWhereCondition = "loai_nh=2";
		((TextBoxBase)txtMa_Nhts2).MaxLength = 8;
		((Control)txtMa_Nhts2).Name = "txtMa_Nhts2";
		txtMa_Nhts2.NameControl = lblTen_Nhts2;
		AsTextBox asTextBox15 = txtMa_Nhts2;
		size = new Size(87, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_Nhts2).TabIndex = 5;
		txtMa_Nhts2.UseAutoCompleteSource = true;
		((Control)lblTen_Nhts2).BackColor = Color.Transparent;
		Label obj41 = lblTen_Nhts2;
		location = new Point(225, 158);
		((Control)obj41).Location = location;
		((Control)lblTen_Nhts2).Name = "lblTen_Nhts2";
		Label obj42 = lblTen_Nhts2;
		size = new Size(317, 13);
		((Control)obj42).Size = size;
		((Control)lblTen_Nhts2).TabIndex = 1331;
		lblMa_Nhts2.AutoSize = true;
		Label obj43 = lblMa_Nhts2;
		location = new Point(24, 158);
		((Control)obj43).Location = location;
		((Control)lblMa_Nhts2).Name = "lblMa_Nhts2";
		Label obj44 = lblMa_Nhts2;
		size = new Size(74, 13);
		((Control)obj44).Size = size;
		((Control)lblMa_Nhts2).TabIndex = 1330;
		lblMa_Nhts2.Text = "Mã nhóm TS2";
		((ComboBox)cboNhom_cap1).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom_cap1).FormattingEnabled = true;
		AsComboBox asComboBox = cboNhom_cap1;
		location = new Point(122, 277);
		((Control)asComboBox).Location = location;
		((Control)cboNhom_cap1).Name = "cboNhom_cap1";
		AsComboBox asComboBox2 = cboNhom_cap1;
		size = new Size(248, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboNhom_cap1).TabIndex = 1344;
		lblNhom_cap3.AutoSize = true;
		Label obj45 = lblNhom_cap3;
		location = new Point(24, 334);
		((Control)obj45).Location = location;
		((Control)lblNhom_cap3).Name = "lblNhom_cap3";
		Label obj46 = lblNhom_cap3;
		size = new Size(65, 13);
		((Control)obj46).Size = size;
		((Control)lblNhom_cap3).TabIndex = 1349;
		lblNhom_cap3.Text = "Nhóm cấp 3";
		((ComboBox)cboNhom_cap3).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom_cap3).FormattingEnabled = true;
		AsComboBox asComboBox3 = cboNhom_cap3;
		location = new Point(122, 330);
		((Control)asComboBox3).Location = location;
		((Control)cboNhom_cap3).Name = "cboNhom_cap3";
		AsComboBox asComboBox4 = cboNhom_cap3;
		size = new Size(248, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboNhom_cap3).TabIndex = 1346;
		lblNhom_cap2.AutoSize = true;
		Label obj47 = lblNhom_cap2;
		location = new Point(24, 307);
		((Control)obj47).Location = location;
		((Control)lblNhom_cap2).Name = "lblNhom_cap2";
		Label obj48 = lblNhom_cap2;
		size = new Size(65, 13);
		((Control)obj48).Size = size;
		((Control)lblNhom_cap2).TabIndex = 1348;
		lblNhom_cap2.Text = "Nhóm cấp 2";
		((ComboBox)cboNhom_cap2).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom_cap2).FormattingEnabled = true;
		AsComboBox asComboBox5 = cboNhom_cap2;
		location = new Point(122, 303);
		((Control)asComboBox5).Location = location;
		((Control)cboNhom_cap2).Name = "cboNhom_cap2";
		AsComboBox asComboBox6 = cboNhom_cap2;
		size = new Size(248, 21);
		((Control)asComboBox6).Size = size;
		((Control)cboNhom_cap2).TabIndex = 1345;
		lblNhom_cap1.AutoSize = true;
		Label obj49 = lblNhom_cap1;
		location = new Point(24, 280);
		((Control)obj49).Location = location;
		((Control)lblNhom_cap1).Name = "lblNhom_cap1";
		Label obj50 = lblNhom_cap1;
		size = new Size(65, 13);
		((Control)obj50).Size = size;
		((Control)lblNhom_cap1).TabIndex = 1347;
		lblNhom_cap1.Text = "Nhóm cấp 1";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(689, 525);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFARptBCTS04";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
		((Control)cboKyBc).Select();
		GroupItem groupItem = new GroupItem("", "");
		ar[0] = groupItem;
		groupItem = new GroupItem("Ma_bpsd", "Bộ phận sử dụng");
		ar[1] = groupItem;
		groupItem = new GroupItem("ma_phi", "Phí");
		ar[2] = groupItem;
		groupItem = new GroupItem("ma_spct", "Sản phẩm công trình");
		ar[3] = groupItem;
		groupItem = new GroupItem("ma_nhts1", "Nhóm tài sản 1");
		ar[4] = groupItem;
		groupItem = new GroupItem("ma_nhts2", "Nhóm tài sản 2");
		ar[5] = groupItem;
		groupItem = new GroupItem("ma_nhts3", "Nhóm tài sản 3");
		ar[6] = groupItem;
		((ComboBox)cboNhom_cap1).Items.Clear();
		checked
		{
			int num = ar.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				((ComboBox)cboNhom_cap1).Items.Add(RuntimeHelpers.GetObjectValue(ar[num2]));
				num2++;
			}
			((ListControl)cboNhom_cap1).ValueMember = "Value";
			((ListControl)cboNhom_cap1).DisplayMember = "Text";
		}
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_ts).Text.Trim());
		arrayList.Add(((TextBox)txtMa_Nhts1).Text.Trim());
		arrayList.Add(((TextBox)txtMa_Nhts2).Text.Trim());
		arrayList.Add(((TextBox)txtMa_Nhts3).Text.Trim());
		arrayList.Add(((TextBox)txtMa_BPSD).Text.Trim());
		arrayList.Add(((TextBox)txtMa_Phi).Text.Trim());
		arrayList.Add(((TextBox)txtMa_SPCT).Text.Trim());
		arrayList.Add(cap1);
		arrayList.Add(cap2);
		arrayList.Add(cap3);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strSubTitle1", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string text = string.Empty;
		if (Operators.CompareString(((TextBox)txtMa_ts).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_ts.Text + ": " + ((TextBox)txtMa_ts).Text;
		}
		if (Operators.CompareString(((TextBox)txtMa_Nhts1).Text.Trim(), "", false) != 0)
		{
			text = text + "  -" + lblMa_Nhts1.Text + ": " + ((TextBox)txtMa_Nhts1).Text;
		}
		if (Operators.CompareString(((TextBox)txtMa_Nhts2).Text.Trim(), "", false) != 0)
		{
			text = text + "  -" + lblMa_Nhts2.Text + ": " + ((TextBox)txtMa_Nhts2).Text;
		}
		if (Operators.CompareString(((TextBox)txtMa_Nhts3).Text.Trim(), "", false) != 0)
		{
			text = text + "  -" + lblMa_Nhts3.Text + ": " + ((TextBox)txtMa_Nhts3).Text;
		}
		if (Operators.CompareString(((TextBox)txtMa_BPSD).Text.Trim(), "", false) != 0)
		{
			text = text + "  -" + lblMa_BPSD.Text + ": " + ((TextBox)txtMa_BPSD).Text;
		}
		if (Operators.CompareString(((TextBox)txtMa_Phi).Text.Trim(), "", false) != 0)
		{
			text = text + "  -" + lblMa_Phi.Text + ": " + ((TextBox)txtMa_Phi).Text;
		}
		if (Operators.CompareString(((TextBox)txtMa_SPCT).Text.Trim(), "", false) != 0)
		{
			text = text + "  -" + lblMa_SPCT.Text + ": " + ((TextBox)txtMa_SPCT).Text;
		}
		return text;
	}

	private void cboNhom_cap1_SelectedIndexChanged(object sender, EventArgs e)
	{
		cap1 = Conversions.ToString((((ComboBox)cboNhom_cap1).SelectedItem as GroupItem).Value);
		((ComboBox)cboNhom_cap2).Items.Clear();
		((ComboBox)cboNhom_cap3).Items.Clear();
		checked
		{
			int num = ar.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (!Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual((ar[num2] as GroupItem).Value, (object)cap1, false), Operators.CompareObjectNotEqual((ar[num2] as GroupItem).Value, (object)"", false))))
				{
					((ComboBox)cboNhom_cap2).Items.Add(RuntimeHelpers.GetObjectValue(ar[num2]));
				}
				num2++;
			}
			((ListControl)cboNhom_cap2).ValueMember = "Value";
			((ListControl)cboNhom_cap2).DisplayMember = "Text";
		}
	}

	private void cboNhom_cap2_SelectedIndexChanged(object sender, EventArgs e)
	{
		cap2 = Conversions.ToString((((ComboBox)cboNhom_cap2).SelectedItem as GroupItem).Value);
		((ComboBox)cboNhom_cap3).Items.Clear();
		checked
		{
			int num = ar.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (!Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.CompareObjectEqual((ar[num2] as GroupItem).Value, (object)cap1, false), Operators.CompareObjectEqual((ar[num2] as GroupItem).Value, (object)cap2, false)), Operators.CompareObjectNotEqual((ar[num2] as GroupItem).Value, (object)"", false))))
				{
					((ComboBox)cboNhom_cap3).Items.Add(RuntimeHelpers.GetObjectValue(ar[num2]));
				}
				num2++;
			}
			((ListControl)cboNhom_cap3).ValueMember = "Value";
			((ListControl)cboNhom_cap3).DisplayMember = "Text";
		}
	}

	private void cboNhom_cap3_SelectedIndexChanged(object sender, EventArgs e)
	{
		cap3 = Conversions.ToString((((ComboBox)cboNhom_cap3).SelectedItem as GroupItem).Value);
	}
}
