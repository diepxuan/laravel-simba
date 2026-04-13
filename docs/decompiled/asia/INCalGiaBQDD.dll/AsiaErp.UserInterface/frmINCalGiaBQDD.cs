using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmINCalGiaBQDD : frmCalc
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cboKieu_ps")]
	private ComboBox _cboKieu_ps;

	[AccessedThroughProperty("lblKieu_pscl")]
	private Label _lblKieu_pscl;

	[AccessedThroughProperty("lblTen_Nhvt")]
	private Label _lblTen_Nhvt;

	[AccessedThroughProperty("lblTen_tkcl")]
	private Label _lblTen_tkcl;

	[AccessedThroughProperty("lblTen_tkvt")]
	private Label _lblTen_tkvt;

	[AccessedThroughProperty("txtMa_NhVt")]
	private AsTextBox _txtMa_NhVt;

	[AccessedThroughProperty("lblTen_Vt")]
	private Label _lblTen_Vt;

	[AccessedThroughProperty("txttk_cl")]
	private AsTextBox _txttk_cl;

	[AccessedThroughProperty("txtMa_tkvt")]
	private AsTextBox _txtMa_tkvt;

	[AccessedThroughProperty("lblNh_vt")]
	private Label _lblNh_vt;

	[AccessedThroughProperty("lblMa_tkcl")]
	private Label _lblMa_tkcl;

	[AccessedThroughProperty("lblTen_Kho")]
	private Label _lblTen_Kho;

	[AccessedThroughProperty("lblMa_tk")]
	private Label _lblMa_tk;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("lblTo")]
	private Label _lblTo;

	[AccessedThroughProperty("bgWorker")]
	private BackgroundWorker _bgWorker;

	[AccessedThroughProperty("cboKyBc")]
	private AsComboBox _cboKyBc;

	private ArrayList arrKBC;

	internal virtual ComboBox cboKieu_ps
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboKieu_ps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboKieu_ps = value;
		}
	}

	internal virtual Label lblKieu_pscl
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblKieu_pscl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblKieu_pscl = value;
		}
	}

	internal virtual Label lblTen_Nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Nhvt = value;
		}
	}

	internal virtual Label lblTen_tkcl
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tkcl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tkcl = value;
		}
	}

	internal virtual Label lblTen_tkvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tkvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tkvt = value;
		}
	}

	internal virtual AsTextBox txtMa_NhVt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_NhVt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_NhVt = value;
		}
	}

	internal virtual Label lblTen_Vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Vt = value;
		}
	}

	internal virtual AsTextBox txttk_cl
	{
		[DebuggerNonUserCode]
		get
		{
			return _txttk_cl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txttk_cl = value;
		}
	}

	internal virtual AsTextBox txtMa_tkvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_tkvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_tkvt = value;
		}
	}

	internal virtual Label lblNh_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNh_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNh_vt = value;
		}
	}

	internal virtual Label lblMa_tkcl
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_tkcl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_tkcl = value;
		}
	}

	internal virtual Label lblTen_Kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Kho = value;
		}
	}

	internal virtual Label lblMa_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_tk = value;
		}
	}

	internal virtual AsTextBox txtMa_vt
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

	internal virtual AsTextBox txtMa_kho
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

	internal virtual Label lblTo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTo = value;
		}
	}

	internal virtual BackgroundWorker bgWorker
	{
		[DebuggerNonUserCode]
		get
		{
			return _bgWorker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_bgWorker = value;
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
			_cboKyBc = value;
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

	public frmINCalGiaBQDD(string MenuID)
		: base(MenuID)
	{
		__ENCAddToList(this);
		arrKBC = new ArrayList();
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
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
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
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		cboKieu_ps = new ComboBox();
		lblKieu_pscl = new Label();
		lblTen_Nhvt = new Label();
		lblTen_tkcl = new Label();
		lblTen_tkvt = new Label();
		txtMa_NhVt = new AsTextBox();
		lblTen_Vt = new Label();
		txttk_cl = new AsTextBox();
		txtMa_tkvt = new AsTextBox();
		lblNh_vt = new Label();
		lblMa_tkcl = new Label();
		lblTen_Kho = new Label();
		lblMa_tk = new Label();
		txtMa_vt = new AsTextBox();
		lblMa_vt = new Label();
		txtMa_kho = new AsTextBox();
		lblMa_kho = new Label();
		lblTo = new Label();
		bgWorker = new BackgroundWorker();
		cboKyBc = new AsComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 221);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		((Control)gbInput).Controls.Add((Control)(object)cboKyBc);
		((Control)gbInput).Controls.Add((Control)(object)cboKieu_ps);
		((Control)gbInput).Controls.Add((Control)(object)lblKieu_pscl);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_Nhvt);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_tkcl);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_tkvt);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_NhVt);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_Vt);
		((Control)gbInput).Controls.Add((Control)(object)txttk_cl);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_tkvt);
		((Control)gbInput).Controls.Add((Control)(object)lblNh_vt);
		((Control)gbInput).Controls.Add((Control)(object)lblMa_tkcl);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_Kho);
		((Control)gbInput).Controls.Add((Control)(object)lblMa_tk);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_vt);
		((Control)gbInput).Controls.Add((Control)(object)lblMa_vt);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_kho);
		((Control)gbInput).Controls.Add((Control)(object)lblMa_kho);
		((Control)gbInput).Controls.Add((Control)(object)lblTo);
		GroupBox obj2 = gbInput;
		Size size = new Size(579, 206);
		((Control)obj2).Size = size;
		((Control)gbInput).TabIndex = 0;
		Button obj3 = cmdOK;
		location = new Point(12, 221);
		((Control)obj3).Location = location;
		((Control)cmdOK).TabIndex = 1;
		cboKieu_ps.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKieu_ps).FormattingEnabled = true;
		cboKieu_ps.Items.AddRange(new object[3] { "0 - Không tạo", "1 - Tạo cho các trường hợp số lượng = 0,số tiền #0", "2 - Tạo cho tất cả các trường hợp có phát sinh chênh lệch" });
		ComboBox obj4 = cboKieu_ps;
		location = new Point(150, 149);
		((Control)obj4).Location = location;
		((Control)cboKieu_ps).Name = "cboKieu_ps";
		ComboBox obj5 = cboKieu_ps;
		size = new Size(280, 21);
		((Control)obj5).Size = size;
		((Control)cboKieu_ps).TabIndex = 6;
		lblKieu_pscl.AutoSize = true;
		Label obj6 = lblKieu_pscl;
		location = new Point(20, 153);
		((Control)obj6).Location = location;
		((Control)lblKieu_pscl).Name = "lblKieu_pscl";
		Label obj7 = lblKieu_pscl;
		size = new Size(119, 13);
		((Control)obj7).Size = size;
		((Control)lblKieu_pscl).TabIndex = 25;
		lblKieu_pscl.Text = "Kiểu tạo PS chênh lệch";
		Label obj8 = lblTen_Nhvt;
		location = new Point(278, 72);
		((Control)obj8).Location = location;
		((Control)lblTen_Nhvt).Name = "lblTen_Nhvt";
		Label obj9 = lblTen_Nhvt;
		size = new Size(289, 18);
		((Control)obj9).Size = size;
		((Control)lblTen_Nhvt).TabIndex = 22;
		Label obj10 = lblTen_tkcl;
		location = new Point(219, 179);
		((Control)obj10).Location = location;
		((Control)lblTen_tkcl).Name = "lblTen_tkcl";
		Label obj11 = lblTen_tkcl;
		size = new Size(348, 18);
		((Control)obj11).Size = size;
		((Control)lblTen_tkcl).TabIndex = 24;
		Label obj12 = lblTen_tkvt;
		location = new Point(278, 124);
		((Control)obj12).Location = location;
		((Control)lblTen_tkvt).Name = "lblTen_tkvt";
		Label obj13 = lblTen_tkvt;
		size = new Size(289, 18);
		((Control)obj13).Size = size;
		((Control)lblTen_tkvt).TabIndex = 21;
		txtMa_NhVt.AutoLookup = true;
		txtMa_NhVt.AutoValid = false;
		((TextBoxBase)txtMa_NhVt).BackColor = SystemColors.Info;
		((TextBox)txtMa_NhVt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_NhVt;
		location = new Point(150, 71);
		((Control)asTextBox).Location = location;
		txtMa_NhVt.LookupCodeName = "MA_NHVT";
		((Control)txtMa_NhVt).Name = "txtMa_NhVt";
		txtMa_NhVt.NameControl = lblTen_Nhvt;
		AsTextBox asTextBox2 = txtMa_NhVt;
		size = new Size(122, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_NhVt).TabIndex = 3;
		((Control)txtMa_NhVt).Tag = "MA_NHVT";
		txtMa_NhVt.UseAutoCompleteSource = true;
		Label obj14 = lblTen_Vt;
		location = new Point(278, 98);
		((Control)obj14).Location = location;
		((Control)lblTen_Vt).Name = "lblTen_Vt";
		Label obj15 = lblTen_Vt;
		size = new Size(289, 18);
		((Control)obj15).Size = size;
		((Control)lblTen_Vt).TabIndex = 23;
		txttk_cl.AutoLookup = true;
		txttk_cl.AutoValid = true;
		((TextBoxBase)txttk_cl).BackColor = SystemColors.Info;
		((TextBox)txttk_cl).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txttk_cl;
		location = new Point(150, 176);
		((Control)asTextBox3).Location = location;
		txttk_cl.LookupCodeName = "TK";
		txttk_cl.LookupWhereCondition = "chi_tiet ='1'";
		((Control)txttk_cl).Name = "txttk_cl";
		txttk_cl.NameControl = lblTen_tkcl;
		AsTextBox asTextBox4 = txttk_cl;
		size = new Size(63, 20);
		((Control)asTextBox4).Size = size;
		((Control)txttk_cl).TabIndex = 7;
		((Control)txttk_cl).Tag = "TK";
		txttk_cl.UseAutoCompleteSource = true;
		txtMa_tkvt.AutoLookup = true;
		txtMa_tkvt.AutoValid = false;
		((TextBoxBase)txtMa_tkvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_tkvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_tkvt;
		location = new Point(150, 123);
		((Control)asTextBox5).Location = location;
		txtMa_tkvt.LookupCodeName = "TK";
		((Control)txtMa_tkvt).Name = "txtMa_tkvt";
		txtMa_tkvt.NameControl = lblTen_tkvt;
		AsTextBox asTextBox6 = txtMa_tkvt;
		size = new Size(122, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_tkvt).TabIndex = 5;
		((Control)txtMa_tkvt).Tag = "TK";
		txtMa_tkvt.UseAutoCompleteSource = true;
		lblNh_vt.AutoSize = true;
		Label obj16 = lblNh_vt;
		location = new Point(20, 75);
		((Control)obj16).Location = location;
		((Control)lblNh_vt).Name = "lblNh_vt";
		Label obj17 = lblNh_vt;
		size = new Size(65, 13);
		((Control)obj17).Size = size;
		((Control)lblNh_vt).TabIndex = 14;
		lblNh_vt.Text = "Nhóm vật tư";
		lblMa_tkcl.AutoSize = true;
		Label obj18 = lblMa_tkcl;
		location = new Point(20, 180);
		((Control)obj18).Location = location;
		((Control)lblMa_tkcl).Name = "lblMa_tkcl";
		Label obj19 = lblMa_tkcl;
		size = new Size(77, 13);
		((Control)obj19).Size = size;
		((Control)lblMa_tkcl).TabIndex = 13;
		lblMa_tkcl.Text = "TK chênh lệch";
		Label obj20 = lblTen_Kho;
		location = new Point(278, 46);
		((Control)obj20).Location = location;
		((Control)lblTen_Kho).Name = "lblTen_Kho";
		Label obj21 = lblTen_Kho;
		size = new Size(289, 18);
		((Control)obj21).Size = size;
		((Control)lblTen_Kho).TabIndex = 19;
		lblMa_tk.AutoSize = true;
		Label obj22 = lblMa_tk;
		location = new Point(20, 127);
		((Control)obj22).Location = location;
		((Control)lblMa_tk).Name = "lblMa_tk";
		Label obj23 = lblMa_tk;
		size = new Size(51, 13);
		((Control)obj23).Size = size;
		((Control)lblMa_tk).TabIndex = 12;
		lblMa_tk.Text = "TK vật tư";
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_vt;
		location = new Point(150, 97);
		((Control)asTextBox7).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_Vt;
		AsTextBox asTextBox8 = txtMa_vt;
		size = new Size(122, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_vt).TabIndex = 4;
		((Control)txtMa_vt).Tag = "MA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		lblMa_vt.AutoSize = true;
		Label obj24 = lblMa_vt;
		location = new Point(20, 101);
		((Control)obj24).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj25 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj25).Size = size;
		((Control)lblMa_vt).TabIndex = 16;
		lblMa_vt.Text = "Mã vật tư";
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_kho;
		location = new Point(150, 45);
		((Control)asTextBox9).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_Kho;
		AsTextBox asTextBox10 = txtMa_kho;
		size = new Size(122, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_kho).TabIndex = 2;
		((Control)txtMa_kho).Tag = "MA_KHO";
		txtMa_kho.UseAutoCompleteSource = true;
		lblMa_kho.AutoSize = true;
		Label obj26 = lblMa_kho;
		location = new Point(20, 49);
		((Control)obj26).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj27 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj27).Size = size;
		((Control)lblMa_kho).TabIndex = 17;
		lblMa_kho.Text = "Mã kho";
		lblTo.AutoSize = true;
		Label obj28 = lblTo;
		location = new Point(20, 23);
		((Control)obj28).Location = location;
		((Control)lblTo).Name = "lblTo";
		Label obj29 = lblTo;
		size = new Size(41, 13);
		((Control)obj29).Size = size;
		((Control)lblTo).TabIndex = 10;
		lblTo.Text = "Kỳ tính";
		((ComboBox)cboKyBc).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKyBc).FormattingEnabled = true;
		AsComboBox asComboBox = cboKyBc;
		location = new Point(150, 19);
		((Control)asComboBox).Location = location;
		((Control)cboKyBc).Name = "cboKyBc";
		AsComboBox asComboBox2 = cboKyBc;
		size = new Size(63, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(601, 253);
		((Form)this).ClientSize = size;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmINCalGiaBQDD";
		((Form)this).Text = "Tính giá bình quân di động";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override bool ValidData()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Compare(((KyBaoCao)((ComboBox)cboKyBc).SelectedItem).ngay2, AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks) <= 0)
		{
			CMessageBox.Show(50136);
			return false;
		}
		if (Conversion.Val(cboKieu_ps.Text[0]) != 0 && Operators.CompareString(((TextBox)txttk_cl).Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txttk_cl, Helper.GetMessContent(50002));
			return false;
		}
		DataRow pDrw = null;
		if (!Commons.ValidMa(ref pDrw, "tk", ((TextBox)txttk_cl).Text, "chi_tiet = '1'", "tk,ten_tk"))
		{
			epNotice.SetError((Control)(object)txttk_cl, Helper.GetMess(50160).Description);
			((Control)txttk_cl).Select();
			return false;
		}
		return true;
	}

	protected override bool Execute()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		((Control)cmdCancel).Enabled = false;
		((Control)cmdOK).Enabled = false;
		bool flag = false;
		try
		{
			((Control)this).Cursor = Cursors.WaitCursor;
			ArrayList arrayList = new ArrayList();
			KyBaoCao kyBaoCao = (KyBaoCao)((ComboBox)cboKyBc).SelectedItem;
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(kyBaoCao.ngay1);
			arrayList.Add(kyBaoCao.ngay2);
			arrayList.Add(((TextBox)txtMa_vt).Text.Trim());
			arrayList.Add(((TextBox)txtMa_tkvt).Text.Trim());
			arrayList.Add(((TextBox)txtMa_NhVt).Text.Trim());
			arrayList.Add(((TextBox)txtMa_kho).Text.Trim());
			arrayList.Add(((TextBox)txttk_cl).Text.Trim());
			arrayList.Add(cboKieu_ps.Text[0]);
			switch ((int)AsiaErp.Framework.Environment.GetCalcInformation(MyMenuID).rettype)
			{
			case 0:
				flag = Conversions.ToBoolean(base.MyController.Execute(arrayList.ToArray()));
				break;
			case 2:
				ResultSource = (DataTable)base.MyController.Execute(arrayList.ToArray());
				break;
			}
			((Control)this).Cursor = Cursors.Default;
			CMessageBox.Show(50015);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			flag = false;
			((Control)this).Cursor = Cursors.Default;
			CMessageBox.Show(50010);
			ProjectData.ClearProjectError();
		}
		((Form)this).Close();
		bool result = default(bool);
		return result;
	}

	protected override void InitComponents()
	{
		base.InitComponents();
		cboKieu_ps.SelectedIndex = 1;
		InitKyBaoCao();
		((ComboBox)cboKyBc).Text = Conversions.ToString(AsiaErp.Framework.Environment.get_PublicVariables("thang1"));
		if (((ListControl)cboKyBc).SelectedValue == null)
		{
			((ComboBox)cboKyBc).SelectedIndex = 1;
		}
		((Control)cboKyBc).Select();
		string tk_gv = AsiaErp.Framework.Environment.GetINConfiguration().tk_gv;
		((TextBox)txttk_cl).Text = Conversions.ToString(Interaction.IIf(Operators.CompareString(tk_gv, "", false) != 0, (object)tk_gv, (object)"632"));
	}

	private void InitKyBaoCao()
	{
		arrKBC = AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc, "11110");
		((ComboBox)cboKyBc).DataSource = arrKBC;
		((ListControl)cboKyBc).ValueMember = "ma";
		((ListControl)cboKyBc).DisplayMember = "ten_ky";
	}
}
