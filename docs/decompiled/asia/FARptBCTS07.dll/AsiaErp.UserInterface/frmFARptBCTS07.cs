using System;
using System.Collections;
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
public class frmFARptBCTS07 : frmReport
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

	[AccessedThroughProperty("lblTen_Spct")]
	private Label _lblTen_Spct;

	[AccessedThroughProperty("txtMa_Spct")]
	private AsTextBox _txtMa_Spct;

	[AccessedThroughProperty("lblMa_Spct")]
	private Label _lblMa_Spct;

	[AccessedThroughProperty("lblTen_Phi")]
	private Label _lblTen_Phi;

	[AccessedThroughProperty("txtMa_Phi")]
	private AsTextBox _txtMa_Phi;

	[AccessedThroughProperty("lblMa_Phi")]
	private Label _lblMa_Phi;

	[AccessedThroughProperty("lblTen_Bp")]
	private Label _lblTen_Bp;

	[AccessedThroughProperty("txtMa_Bp")]
	private AsTextBox _txtMa_Bp;

	[AccessedThroughProperty("lblMa_Bp")]
	private Label _lblMa_Bp;

	[AccessedThroughProperty("lblTen_nhts3")]
	private Label _lblTen_nhts3;

	[AccessedThroughProperty("txtMa_nhts3")]
	private AsTextBox _txtMa_nhts3;

	[AccessedThroughProperty("lblMa_nhts3")]
	private Label _lblMa_nhts3;

	[AccessedThroughProperty("lblTen_nhts2")]
	private Label _lblTen_nhts2;

	[AccessedThroughProperty("txtMa_nhts2")]
	private AsTextBox _txtMa_nhts2;

	[AccessedThroughProperty("lblMa_nhts2")]
	private Label _lblMa_nhts2;

	[AccessedThroughProperty("lblTen_nhts1")]
	private Label _lblTen_nhts1;

	[AccessedThroughProperty("txtMa_nhts1")]
	private AsTextBox _txtMa_nhts1;

	[AccessedThroughProperty("lblMa_nhts1")]
	private Label _lblMa_nhts1;

	[AccessedThroughProperty("lblTen_TS")]
	private Label _lblTen_TS;

	[AccessedThroughProperty("txtMa_TS")]
	private AsTextBox _txtMa_TS;

	[AccessedThroughProperty("lblMa_ts")]
	private Label _lblMa_ts;

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

	[AccessedThroughProperty("txtNgay")]
	private AsMaskedTextBox _txtNgay;

	private object[] ar;

	private string cap1;

	private string cap2;

	private string cap3;

	internal virtual Label lblTen_Spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Spct = value;
		}
	}

	internal virtual AsTextBox txtMa_Spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Spct = value;
		}
	}

	internal virtual Label lblMa_Spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Spct = value;
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

	internal virtual Label lblTen_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Bp = value;
		}
	}

	internal virtual AsTextBox txtMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Bp = value;
		}
	}

	internal virtual Label lblMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Bp = value;
		}
	}

	internal virtual Label lblTen_nhts3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nhts3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nhts3 = value;
		}
	}

	internal virtual AsTextBox txtMa_nhts3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nhts3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nhts3 = value;
		}
	}

	internal virtual Label lblMa_nhts3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nhts3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nhts3 = value;
		}
	}

	internal virtual Label lblTen_nhts2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nhts2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nhts2 = value;
		}
	}

	internal virtual AsTextBox txtMa_nhts2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nhts2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nhts2 = value;
		}
	}

	internal virtual Label lblMa_nhts2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nhts2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nhts2 = value;
		}
	}

	internal virtual Label lblTen_nhts1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nhts1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nhts1 = value;
		}
	}

	internal virtual AsTextBox txtMa_nhts1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nhts1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nhts1 = value;
		}
	}

	internal virtual Label lblMa_nhts1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nhts1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nhts1 = value;
		}
	}

	internal virtual Label lblTen_TS
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_TS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_TS = value;
		}
	}

	internal virtual AsTextBox txtMa_TS
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_TS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_TS = value;
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

	internal virtual AsMaskedTextBox txtNgay
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay = value;
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
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		lblTen_Spct = new Label();
		txtMa_Spct = new AsTextBox();
		lblMa_Spct = new Label();
		lblTen_Phi = new Label();
		txtMa_Phi = new AsTextBox();
		lblMa_Phi = new Label();
		lblTen_Bp = new Label();
		txtMa_Bp = new AsTextBox();
		lblMa_Bp = new Label();
		lblTen_TS = new Label();
		txtMa_TS = new AsTextBox();
		lblMa_ts = new Label();
		lblTen_nhts1 = new Label();
		txtMa_nhts1 = new AsTextBox();
		lblMa_nhts1 = new Label();
		lblTen_nhts2 = new Label();
		txtMa_nhts2 = new AsTextBox();
		lblMa_nhts2 = new Label();
		lblTen_nhts3 = new Label();
		txtMa_nhts3 = new AsTextBox();
		lblMa_nhts3 = new Label();
		cboNhom_cap1 = new AsComboBox();
		lblNhom_cap3 = new Label();
		cboNhom_cap3 = new AsComboBox();
		lblNhom_cap2 = new Label();
		cboNhom_cap2 = new AsComboBox();
		lblNhom_cap1 = new Label();
		txtNgay = new AsMaskedTextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(728, 480);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)txtNgay);
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom_cap1);
		((Control)tabFilter).Controls.Add((Control)(object)lblNhom_cap3);
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom_cap3);
		((Control)tabFilter).Controls.Add((Control)(object)lblNhom_cap2);
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom_cap2);
		((Control)tabFilter).Controls.Add((Control)(object)lblNhom_cap1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhts3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhts3);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhts3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhts2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhts2);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhts2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhts1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhts1);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhts1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_TS);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_TS);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_ts);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Spct);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Bp);
		TabPage obj = tabFilter;
		size = new Size(720, 451);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_ts, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_TS, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_TS, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhts1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhts1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhts1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhts2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhts2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhts2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhts3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhts3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhts3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNhom_cap1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom_cap2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNhom_cap2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom_cap3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNhom_cap3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom_cap1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay, 0);
		Label obj2 = lbl2;
		Point location = new Point(505, 83);
		((Control)obj2).Location = location;
		((Control)lbl2).Visible = false;
		Button obj3 = cmdExcel;
		location = new Point(554, 1015);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 11;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(507, 78);
		((Control)asMaskedTextBox).Location = location;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay2;
		size = new Size(90, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay2).TabIndex = 2;
		((Control)txtNgay2).Visible = false;
		Button obj4 = cmdCancel;
		location = new Point(473, 1015);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 31;
		Button obj5 = cmdModifyReport;
		location = new Point(455, 24);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 15;
		AsMaskedTextBox asMaskedTextBox3 = txtNgay1;
		location = new Point(434, 79);
		((Control)asMaskedTextBox3).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		((Control)txtNgay1).Visible = false;
		ComboBox obj6 = cboKyBc;
		location = new Point(338, 78);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		((Control)cboKyBc).Visible = false;
		Label obj7 = lblKyBc;
		size = new Size(48, 13);
		((Control)obj7).Size = size;
		lblKyBc.Text = "Tại ngày";
		((Control)cboMau_bc).TabIndex = 14;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 575);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 22;
		((Control)txtMa_Nt).Visible = false;
		Label obj8 = lblMauBC;
		location = new Point(155, 575);
		((Control)obj8).Location = location;
		((Control)lblMauBC).Visible = false;
		RadioButton obj9 = optVND;
		location = new Point(245, 575);
		((Control)obj9).Location = location;
		((Control)optVND).TabIndex = 23;
		((Control)optVND).Visible = false;
		RadioButton obj10 = optNt;
		location = new Point(309, 575);
		((Control)obj10).Location = location;
		((Control)optNt).TabIndex = 24;
		((Control)optNt).Visible = false;
		Label obj11 = lblMa_nt;
		location = new Point(24, 578);
		((Control)obj11).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj12 = cmdOk;
		location = new Point(27, 373);
		((Control)obj12).Location = location;
		((Control)cmdOk).TabIndex = 13;
		((Control)lblTieu_de).TabIndex = 28;
		((Control)txtTieu_De).TabIndex = 16;
		TabPage obj13 = tabGrid;
		size = new Size(720, 451);
		((Control)obj13).Size = size;
		lblTen_Spct.ImeMode = (ImeMode)0;
		Label obj14 = lblTen_Spct;
		location = new Point(212, 263);
		((Control)obj14).Location = location;
		((Control)lblTen_Spct).Name = "lblTen_Spct";
		Label obj15 = lblTen_Spct;
		size = new Size(366, 13);
		((Control)obj15).Size = size;
		((Control)lblTen_Spct).TabIndex = 1091;
		lblTen_Spct.TextAlign = (ContentAlignment)16;
		txtMa_Spct.AutoLookup = true;
		txtMa_Spct.AutoValid = false;
		((TextBoxBase)txtMa_Spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_Spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_Spct;
		location = new Point(110, 261);
		((Control)asTextBox2).Location = location;
		txtMa_Spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_Spct).Name = "txtMa_Spct";
		txtMa_Spct.NameControl = lblTen_Spct;
		AsTextBox asTextBox3 = txtMa_Spct;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_Spct).TabIndex = 9;
		txtMa_Spct.UseAutoCompleteSource = true;
		lblMa_Spct.AutoSize = true;
		lblMa_Spct.ImeMode = (ImeMode)0;
		Label obj16 = lblMa_Spct;
		location = new Point(24, 265);
		((Control)obj16).Location = location;
		((Control)lblMa_Spct).Name = "lblMa_Spct";
		Label obj17 = lblMa_Spct;
		size = new Size(53, 13);
		((Control)obj17).Size = size;
		((Control)lblMa_Spct).TabIndex = 1090;
		lblMa_Spct.Text = "Mã SPCT";
		lblTen_Phi.ImeMode = (ImeMode)0;
		Label obj18 = lblTen_Phi;
		location = new Point(212, 238);
		((Control)obj18).Location = location;
		((Control)lblTen_Phi).Name = "lblTen_Phi";
		Label obj19 = lblTen_Phi;
		size = new Size(366, 13);
		((Control)obj19).Size = size;
		((Control)lblTen_Phi).TabIndex = 1085;
		lblTen_Phi.TextAlign = (ContentAlignment)16;
		txtMa_Phi.AutoLookup = true;
		txtMa_Phi.AutoValid = false;
		((TextBoxBase)txtMa_Phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_Phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_Phi;
		location = new Point(110, 235);
		((Control)asTextBox4).Location = location;
		txtMa_Phi.LookupCodeName = "MA_PHI";
		((Control)txtMa_Phi).Name = "txtMa_Phi";
		txtMa_Phi.NameControl = lblTen_Phi;
		AsTextBox asTextBox5 = txtMa_Phi;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_Phi).TabIndex = 8;
		txtMa_Phi.UseAutoCompleteSource = true;
		lblMa_Phi.AutoSize = true;
		lblMa_Phi.ImeMode = (ImeMode)0;
		Label obj20 = lblMa_Phi;
		location = new Point(24, 238);
		((Control)obj20).Location = location;
		((Control)lblMa_Phi).Name = "lblMa_Phi";
		Label obj21 = lblMa_Phi;
		size = new Size(41, 13);
		((Control)obj21).Size = size;
		((Control)lblMa_Phi).TabIndex = 1084;
		lblMa_Phi.Text = "Mã phí";
		lblTen_Bp.ImeMode = (ImeMode)0;
		Label obj22 = lblTen_Bp;
		location = new Point(212, 212);
		((Control)obj22).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj23 = lblTen_Bp;
		size = new Size(366, 13);
		((Control)obj23).Size = size;
		((Control)lblTen_Bp).TabIndex = 1083;
		lblTen_Bp.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_Bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Bp.AutoLookup = true;
		txtMa_Bp.AutoValid = false;
		((TextBoxBase)txtMa_Bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_Bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_Bp;
		location = new Point(110, 209);
		((Control)asTextBox6).Location = location;
		txtMa_Bp.LookupCodeName = "MA_BPSD";
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		txtMa_Bp.NameControl = lblTen_Bp;
		AsTextBox asTextBox7 = txtMa_Bp;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_Bp).TabIndex = 7;
		txtMa_Bp.UseAutoCompleteSource = true;
		lblMa_Bp.AutoSize = true;
		lblMa_Bp.ImeMode = (ImeMode)0;
		Label obj24 = lblMa_Bp;
		location = new Point(24, 213);
		((Control)obj24).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj25 = lblMa_Bp;
		size = new Size(54, 13);
		((Control)obj25).Size = size;
		((Control)lblMa_Bp).TabIndex = 1082;
		lblMa_Bp.Text = "Mã BPSD";
		lblTen_TS.ImeMode = (ImeMode)0;
		Label obj26 = lblTen_TS;
		location = new Point(212, 108);
		((Control)obj26).Location = location;
		((Control)lblTen_TS).Name = "lblTen_TS";
		Label obj27 = lblTen_TS;
		size = new Size(366, 13);
		((Control)obj27).Size = size;
		((Control)lblTen_TS).TabIndex = 1094;
		lblTen_TS.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_TS).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_TS.AutoLookup = true;
		txtMa_TS.AutoValid = false;
		((TextBoxBase)txtMa_TS).BackColor = SystemColors.Info;
		((TextBox)txtMa_TS).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_TS;
		location = new Point(110, 105);
		((Control)asTextBox8).Location = location;
		txtMa_TS.LookupCodeName = "MA_TS";
		((Control)txtMa_TS).Name = "txtMa_TS";
		txtMa_TS.NameControl = lblTen_TS;
		AsTextBox asTextBox9 = txtMa_TS;
		size = new Size(90, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_TS).TabIndex = 3;
		txtMa_TS.UseAutoCompleteSource = true;
		lblMa_ts.AutoSize = true;
		lblMa_ts.ImeMode = (ImeMode)0;
		Label obj28 = lblMa_ts;
		location = new Point(24, 109);
		((Control)obj28).Location = location;
		((Control)lblMa_ts).Name = "lblMa_ts";
		Label obj29 = lblMa_ts;
		size = new Size(56, 13);
		((Control)obj29).Size = size;
		((Control)lblMa_ts).TabIndex = 1093;
		lblMa_ts.Text = "Mã tài sản";
		lblTen_nhts1.ImeMode = (ImeMode)0;
		Label obj30 = lblTen_nhts1;
		location = new Point(212, 134);
		((Control)obj30).Location = location;
		((Control)lblTen_nhts1).Name = "lblTen_nhts1";
		Label obj31 = lblTen_nhts1;
		size = new Size(366, 13);
		((Control)obj31).Size = size;
		((Control)lblTen_nhts1).TabIndex = 1097;
		lblTen_nhts1.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_nhts1).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_nhts1.AutoLookup = true;
		txtMa_nhts1.AutoValid = false;
		((TextBoxBase)txtMa_nhts1).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhts1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_nhts1;
		location = new Point(110, 131);
		((Control)asTextBox10).Location = location;
		txtMa_nhts1.LookupCodeName = "Ma_nhts";
		txtMa_nhts1.LookupWhereCondition = "loai_nh= '1'";
		((Control)txtMa_nhts1).Name = "txtMa_nhts1";
		txtMa_nhts1.NameControl = lblTen_nhts1;
		AsTextBox asTextBox11 = txtMa_nhts1;
		size = new Size(90, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_nhts1).TabIndex = 4;
		txtMa_nhts1.UseAutoCompleteSource = true;
		lblMa_nhts1.AutoSize = true;
		lblMa_nhts1.ImeMode = (ImeMode)0;
		Label obj32 = lblMa_nhts1;
		location = new Point(24, 135);
		((Control)obj32).Location = location;
		((Control)lblMa_nhts1).Name = "lblMa_nhts1";
		Label obj33 = lblMa_nhts1;
		size = new Size(74, 13);
		((Control)obj33).Size = size;
		((Control)lblMa_nhts1).TabIndex = 1096;
		lblMa_nhts1.Text = "Mã nhóm TS1";
		lblTen_nhts2.ImeMode = (ImeMode)0;
		Label obj34 = lblTen_nhts2;
		location = new Point(212, 160);
		((Control)obj34).Location = location;
		((Control)lblTen_nhts2).Name = "lblTen_nhts2";
		Label obj35 = lblTen_nhts2;
		size = new Size(366, 13);
		((Control)obj35).Size = size;
		((Control)lblTen_nhts2).TabIndex = 1100;
		lblTen_nhts2.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_nhts2).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_nhts2.AutoLookup = true;
		txtMa_nhts2.AutoValid = false;
		((TextBoxBase)txtMa_nhts2).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhts2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_nhts2;
		location = new Point(110, 157);
		((Control)asTextBox12).Location = location;
		txtMa_nhts2.LookupCodeName = "Ma_nhts";
		txtMa_nhts2.LookupWhereCondition = "loai_nh = '2'";
		((Control)txtMa_nhts2).Name = "txtMa_nhts2";
		txtMa_nhts2.NameControl = lblTen_nhts2;
		AsTextBox asTextBox13 = txtMa_nhts2;
		size = new Size(90, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_nhts2).TabIndex = 5;
		txtMa_nhts2.UseAutoCompleteSource = true;
		lblMa_nhts2.AutoSize = true;
		lblMa_nhts2.ImeMode = (ImeMode)0;
		Label obj36 = lblMa_nhts2;
		location = new Point(24, 161);
		((Control)obj36).Location = location;
		((Control)lblMa_nhts2).Name = "lblMa_nhts2";
		Label obj37 = lblMa_nhts2;
		size = new Size(74, 13);
		((Control)obj37).Size = size;
		((Control)lblMa_nhts2).TabIndex = 1099;
		lblMa_nhts2.Text = "Mã nhóm TS2";
		lblTen_nhts3.ImeMode = (ImeMode)0;
		Label obj38 = lblTen_nhts3;
		location = new Point(212, 186);
		((Control)obj38).Location = location;
		((Control)lblTen_nhts3).Name = "lblTen_nhts3";
		Label obj39 = lblTen_nhts3;
		size = new Size(366, 13);
		((Control)obj39).Size = size;
		((Control)lblTen_nhts3).TabIndex = 1103;
		lblTen_nhts3.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_nhts3).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_nhts3.AutoLookup = true;
		txtMa_nhts3.AutoValid = false;
		((TextBoxBase)txtMa_nhts3).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhts3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtMa_nhts3;
		location = new Point(110, 183);
		((Control)asTextBox14).Location = location;
		txtMa_nhts3.LookupCodeName = "Ma_nhts";
		txtMa_nhts3.LookupWhereCondition = "loai_nh = '3'";
		((Control)txtMa_nhts3).Name = "txtMa_nhts3";
		txtMa_nhts3.NameControl = lblTen_nhts3;
		AsTextBox asTextBox15 = txtMa_nhts3;
		size = new Size(90, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_nhts3).TabIndex = 6;
		txtMa_nhts3.UseAutoCompleteSource = true;
		lblMa_nhts3.AutoSize = true;
		lblMa_nhts3.ImeMode = (ImeMode)0;
		Label obj40 = lblMa_nhts3;
		location = new Point(24, 187);
		((Control)obj40).Location = location;
		((Control)lblMa_nhts3).Name = "lblMa_nhts3";
		Label obj41 = lblMa_nhts3;
		size = new Size(74, 13);
		((Control)obj41).Size = size;
		((Control)lblMa_nhts3).TabIndex = 1102;
		lblMa_nhts3.Text = "Mã nhóm TS3";
		((ComboBox)cboNhom_cap1).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom_cap1).FormattingEnabled = true;
		AsComboBox asComboBox = cboNhom_cap1;
		location = new Point(110, 287);
		((Control)asComboBox).Location = location;
		((Control)cboNhom_cap1).Name = "cboNhom_cap1";
		AsComboBox asComboBox2 = cboNhom_cap1;
		size = new Size(248, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboNhom_cap1).TabIndex = 10;
		lblNhom_cap3.AutoSize = true;
		Label obj42 = lblNhom_cap3;
		location = new Point(24, 344);
		((Control)obj42).Location = location;
		((Control)lblNhom_cap3).Name = "lblNhom_cap3";
		Label obj43 = lblNhom_cap3;
		size = new Size(65, 13);
		((Control)obj43).Size = size;
		((Control)lblNhom_cap3).TabIndex = 1355;
		lblNhom_cap3.Text = "Nhóm cấp 3";
		((ComboBox)cboNhom_cap3).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom_cap3).FormattingEnabled = true;
		AsComboBox asComboBox3 = cboNhom_cap3;
		location = new Point(110, 340);
		((Control)asComboBox3).Location = location;
		((Control)cboNhom_cap3).Name = "cboNhom_cap3";
		AsComboBox asComboBox4 = cboNhom_cap3;
		size = new Size(248, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboNhom_cap3).TabIndex = 12;
		lblNhom_cap2.AutoSize = true;
		Label obj44 = lblNhom_cap2;
		location = new Point(24, 317);
		((Control)obj44).Location = location;
		((Control)lblNhom_cap2).Name = "lblNhom_cap2";
		Label obj45 = lblNhom_cap2;
		size = new Size(65, 13);
		((Control)obj45).Size = size;
		((Control)lblNhom_cap2).TabIndex = 1354;
		lblNhom_cap2.Text = "Nhóm cấp 2";
		((ComboBox)cboNhom_cap2).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom_cap2).FormattingEnabled = true;
		AsComboBox asComboBox5 = cboNhom_cap2;
		location = new Point(110, 313);
		((Control)asComboBox5).Location = location;
		((Control)cboNhom_cap2).Name = "cboNhom_cap2";
		AsComboBox asComboBox6 = cboNhom_cap2;
		size = new Size(248, 21);
		((Control)asComboBox6).Size = size;
		((Control)cboNhom_cap2).TabIndex = 11;
		lblNhom_cap1.AutoSize = true;
		Label obj46 = lblNhom_cap1;
		location = new Point(24, 290);
		((Control)obj46).Location = location;
		((Control)lblNhom_cap1).Name = "lblNhom_cap1";
		Label obj47 = lblNhom_cap1;
		size = new Size(65, 13);
		((Control)obj47).Size = size;
		((Control)lblNhom_cap1).TabIndex = 1353;
		lblNhom_cap1.Text = "Nhóm cấp 1";
		txtNgay.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay;
		location = new Point(110, 78);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay).Mask = "##/##/####";
		((Control)txtNgay).Name = "txtNgay";
		((MaskedTextBox)txtNgay).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay;
		size = new Size(90, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay).TabIndex = 2;
		((MaskedTextBox)txtNgay).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(728, 505);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFARptBCTS07";
		((Form)this).Text = "frmFARptBCTS07";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public frmFARptBCTS07(string Menuid)
		: base(Menuid)
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

	protected override bool ValidData()
	{
		if (Operators.CompareString(((MaskedTextBox)txtNgay).Text.ToString().Replace("/", "").Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtNgay, Helper.GetMess(50002).Description);
			((Control)txtNgay).Select();
			return false;
		}
		return base.ValidData();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
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
			txtNgay.Value = DateTime.Now;
		}
	}

	protected override bool LoadData()
	{
		if (ValidData())
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay.Value));
			arrayList.Add(((TextBox)txtMa_TS).Text);
			arrayList.Add(((TextBox)txtMa_nhts1).Text);
			arrayList.Add(((TextBox)txtMa_nhts2).Text);
			arrayList.Add(((TextBox)txtMa_nhts3).Text);
			arrayList.Add(((TextBox)txtMa_Bp).Text);
			arrayList.Add(((TextBox)txtMa_Phi).Text);
			arrayList.Add(((TextBox)txtMa_Spct).Text);
			arrayList.Add(cap1);
			arrayList.Add(cap2);
			arrayList.Add(cap3);
			set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
			base.ViewCrystalBySource();
			base.MyFomularFields.Clear();
			DateTime dateTime = Conversions.ToDate(txtNgay.Value);
			base.MyFomularFields.Add("strSubTitle", "Ngày " + Conversions.ToString(dateTime.Day) + " tháng " + Conversions.ToString(DateAndTime.Month(dateTime)) + " năm " + Conversions.ToString(DateAndTime.Year(dateTime)));
			base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
			return true;
		}
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (Operators.CompareString(((TextBox)txtMa_TS).Text, "", false) != 0)
		{
			text = text + lblMa_ts.Text + ": [" + ((TextBox)txtMa_TS).Text + "], ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhts1).Text, "", false) != 0)
		{
			text = text + lblMa_nhts1.Text + ": [" + ((TextBox)txtMa_nhts1).Text + "], ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhts2).Text, "", false) != 0)
		{
			text = text + lblMa_nhts2.Text + ": [" + ((TextBox)txtMa_nhts2).Text + "], ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhts3).Text, "", false) != 0)
		{
			text = text + lblMa_nhts3.Text + ": [" + ((TextBox)txtMa_nhts3).Text + "], ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Bp).Text, "", false) != 0)
		{
			text = text + lblMa_Bp.Text + ": [" + ((TextBox)txtMa_Bp).Text + "], ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Phi).Text, "", false) != 0)
		{
			text = text + lblMa_Phi.Text + ": [" + ((TextBox)txtMa_Phi).Text + "], ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Spct).Text, "", false) != 0)
		{
			text = text + lblMa_Spct.Text + ": [" + ((TextBox)txtMa_Spct).Text + "], ";
		}
		if (Operators.CompareString(((ComboBox)cboNhom_cap1).Text, "", false) != 0)
		{
			text = text + lblNhom_cap1.Text + ": [" + ((ComboBox)cboNhom_cap1).Text + "], ";
		}
		if (Operators.CompareString(((ComboBox)cboNhom_cap2).Text, "", false) != 0)
		{
			text = text + lblNhom_cap2.Text + ": [" + ((ComboBox)cboNhom_cap2).Text + "], ";
		}
		if (Operators.CompareString(((ComboBox)cboNhom_cap3).Text, "", false) != 0)
		{
			text = text + lblNhom_cap3.Text + ": [" + ((ComboBox)cboNhom_cap3).Text + "]";
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
					((ComboBox)cboNhom_cap3).Items.Add(RuntimeHelpers.GetObjectValue(ar[num2]));
				}
				num2++;
			}
			((ListControl)cboNhom_cap2).ValueMember = "Value";
			((ListControl)cboNhom_cap2).DisplayMember = "Text";
			((ListControl)cboNhom_cap3).ValueMember = "Value";
			((ListControl)cboNhom_cap3).DisplayMember = "Text";
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
