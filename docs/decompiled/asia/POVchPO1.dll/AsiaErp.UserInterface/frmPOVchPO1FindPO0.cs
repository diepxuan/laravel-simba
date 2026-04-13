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
public class frmPOVchPO1FindPO0 : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("txtSo_ct2")]
	private TextBox _txtSo_ct2;

	[AccessedThroughProperty("txtSo_ct1")]
	private TextBox _txtSo_ct1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtNgay_ct2")]
	private AsMaskedTextBox _txtNgay_ct2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtNgay_ct1")]
	private AsMaskedTextBox _txtNgay_ct1;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtDien_giai")]
	private TextBox _txtDien_giai;

	[AccessedThroughProperty("lblDien_giai")]
	private Label _lblDien_giai;

	[AccessedThroughProperty("lblTen_Hd")]
	private Label _lblTen_Hd;

	[AccessedThroughProperty("txtMa_Hd")]
	private AsTextBox _txtMa_Hd;

	[AccessedThroughProperty("lblMa_Hd")]
	private Label _lblMa_Hd;

	[AccessedThroughProperty("lblNguoi_Gd")]
	private Label _lblNguoi_Gd;

	[AccessedThroughProperty("txtNguoi_dn")]
	private TextBox _txtNguoi_dn;

	[AccessedThroughProperty("gbCt")]
	private GroupBox _gbCt;

	[AccessedThroughProperty("lblTen_bp")]
	private Label _lblTen_bp;

	[AccessedThroughProperty("txtMa_bp")]
	private AsTextBox _txtMa_bp;

	[AccessedThroughProperty("lblMa_bp")]
	private Label _lblMa_bp;

	internal string sWhereKey;

	internal string sMa_kh;

	protected virtual Button cmdCancel
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCancel_Click;
			if (_cmdCancel != null)
			{
				((Control)_cmdCancel).Click -= eventHandler;
			}
			_cmdCancel = value;
			if (_cmdCancel != null)
			{
				((Control)_cmdCancel).Click += eventHandler;
			}
		}
	}

	protected virtual Button cmdOk
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOk_Click;
			if (_cmdOk != null)
			{
				((Control)_cmdOk).Click -= eventHandler;
			}
			_cmdOk = value;
			if (_cmdOk != null)
			{
				((Control)_cmdOk).Click += eventHandler;
			}
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

	internal virtual AsMaskedTextBox txtNgay_ct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_ct2 = value;
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

	internal virtual AsMaskedTextBox txtNgay_ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_ct1 = value;
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

	internal virtual Label lblDien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDien_giai = value;
		}
	}

	internal virtual Label lblTen_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Hd = value;
		}
	}

	internal virtual AsTextBox txtMa_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Hd = value;
		}
	}

	internal virtual Label lblMa_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Hd = value;
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

	internal virtual TextBox txtNguoi_dn
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNguoi_dn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNguoi_dn = value;
		}
	}

	protected virtual GroupBox gbCt
	{
		[DebuggerNonUserCode]
		get
		{
			return _gbCt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_gbCt = value;
		}
	}

	internal virtual Label lblTen_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_bp = value;
		}
	}

	internal virtual AsTextBox txtMa_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_bp = value;
		}
	}

	internal virtual Label lblMa_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_bp = value;
		}
	}

	public frmPOVchPO1FindPO0()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmArVchAr1FindSO3SO5_KeyDown);
		__ENCAddToList(this);
		sWhereKey = "";
		sMa_kh = "";
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmPOVchPO1FindPO0));
		cmdCancel = new Button();
		cmdOk = new Button();
		txtSo_ct2 = new TextBox();
		txtSo_ct1 = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		txtNgay_ct2 = new AsMaskedTextBox();
		Label3 = new Label();
		txtNgay_ct1 = new AsMaskedTextBox();
		Label4 = new Label();
		txtDien_giai = new TextBox();
		lblDien_giai = new Label();
		lblTen_Hd = new Label();
		txtMa_Hd = new AsTextBox();
		lblMa_Hd = new Label();
		lblNguoi_Gd = new Label();
		txtNguoi_dn = new TextBox();
		gbCt = new GroupBox();
		lblTen_bp = new Label();
		txtMa_bp = new AsTextBox();
		lblMa_bp = new Label();
		((Control)gbCt).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)cmdCancel).Anchor = (AnchorStyles)6;
		cmdCancel.DialogResult = (DialogResult)2;
		((ButtonBase)cmdCancel).Image = (Image)componentResourceManager.GetObject("cmdCancel.Image");
		((ButtonBase)cmdCancel).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdCancel).ImeMode = (ImeMode)0;
		Button obj = cmdCancel;
		Point location = new Point(91, 195);
		((Control)obj).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj2 = cmdCancel;
		Size size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)cmdCancel).TabIndex = 2;
		((ButtonBase)cmdCancel).Text = "&Quay ra";
		((ButtonBase)cmdCancel).TextAlign = (ContentAlignment)64;
		((Control)cmdOk).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdOk).Image = (Image)componentResourceManager.GetObject("cmdOk.Image");
		((ButtonBase)cmdOk).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdOk).ImeMode = (ImeMode)0;
		Button obj3 = cmdOk;
		location = new Point(10, 195);
		((Control)obj3).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		Button obj4 = cmdOk;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)cmdOk).TabIndex = 1;
		((ButtonBase)cmdOk).Text = "&Nhận";
		((ButtonBase)cmdOk).TextAlign = (ContentAlignment)64;
		TextBox obj5 = txtSo_ct2;
		location = new Point(277, 45);
		((Control)obj5).Location = location;
		((Control)txtSo_ct2).Name = "txtSo_ct2";
		TextBox obj6 = txtSo_ct2;
		size = new Size(82, 20);
		((Control)obj6).Size = size;
		((Control)txtSo_ct2).TabIndex = 3;
		TextBox obj7 = txtSo_ct1;
		location = new Point(131, 45);
		((Control)obj7).Location = location;
		((Control)txtSo_ct1).Name = "txtSo_ct1";
		TextBox obj8 = txtSo_ct1;
		size = new Size(82, 20);
		((Control)obj8).Size = size;
		((Control)txtSo_ct1).TabIndex = 2;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(219, 49);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(26, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 259;
		Label1.Text = "đến";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(7, 49);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(61, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 258;
		Label2.Text = "Số phiếu từ";
		txtNgay_ct2.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct2).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ct2;
		location = new Point(277, 19);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_ct2).Mask = "##/##/####";
		((Control)txtNgay_ct2).Name = "txtNgay_ct2";
		((MaskedTextBox)txtNgay_ct2).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_ct2;
		size = new Size(82, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_ct2).TabIndex = 1;
		((MaskedTextBox)txtNgay_ct2).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_ct2;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(219, 23);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(26, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 257;
		Label3.Text = "đến";
		txtNgay_ct1.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct1).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_ct1;
		location = new Point(131, 19);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_ct1).Mask = "##/##/####";
		((Control)txtNgay_ct1).Name = "txtNgay_ct1";
		((MaskedTextBox)txtNgay_ct1).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_ct1;
		size = new Size(82, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_ct1).TabIndex = 0;
		((MaskedTextBox)txtNgay_ct1).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_ct1;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		Label4.AutoSize = true;
		Label label7 = Label4;
		location = new Point(7, 23);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(83, 13);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 256;
		Label4.Text = "Ngày đề nghị từ";
		txtDien_giai.AutoCompleteMode = (AutoCompleteMode)1;
		txtDien_giai.AutoCompleteSource = (AutoCompleteSource)7;
		TextBox obj9 = txtDien_giai;
		location = new Point(131, 149);
		((Control)obj9).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj10 = txtDien_giai;
		size = new Size(408, 20);
		((Control)obj10).Size = size;
		((Control)txtDien_giai).TabIndex = 7;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj11 = lblDien_giai;
		location = new Point(7, 152);
		((Control)obj11).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj12 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj12).Size = size;
		((Control)lblDien_giai).TabIndex = 255;
		lblDien_giai.Text = "Diễn giải";
		lblTen_Hd.ImeMode = (ImeMode)0;
		Label obj13 = lblTen_Hd;
		location = new Point(219, 127);
		((Control)obj13).Location = location;
		((Control)lblTen_Hd).Name = "lblTen_Hd";
		Label obj14 = lblTen_Hd;
		size = new Size(320, 13);
		((Control)obj14).Size = size;
		((Control)lblTen_Hd).TabIndex = 254;
		lblTen_Hd.TextAlign = (ContentAlignment)16;
		txtMa_Hd.AutoLookup = true;
		txtMa_Hd.AutoValid = false;
		((TextBoxBase)txtMa_Hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_Hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Hd;
		location = new Point(131, 123);
		((Control)asTextBox).Location = location;
		txtMa_Hd.LookupCodeName = "MA_HD";
		((Control)txtMa_Hd).Name = "txtMa_Hd";
		txtMa_Hd.NameControl = lblTen_Hd;
		AsTextBox asTextBox2 = txtMa_Hd;
		size = new Size(82, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Hd).TabIndex = 6;
		txtMa_Hd.UseAutoCompleteSource = true;
		lblMa_Hd.AutoSize = true;
		lblMa_Hd.ImeMode = (ImeMode)0;
		Label obj15 = lblMa_Hd;
		location = new Point(7, 127);
		((Control)obj15).Location = location;
		((Control)lblMa_Hd).Name = "lblMa_Hd";
		Label obj16 = lblMa_Hd;
		size = new Size(71, 13);
		((Control)obj16).Size = size;
		((Control)lblMa_Hd).TabIndex = 253;
		lblMa_Hd.Text = "Mã hợp đồng";
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj17 = lblNguoi_Gd;
		location = new Point(7, 74);
		((Control)obj17).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj18 = lblNguoi_Gd;
		size = new Size(98, 14);
		((Control)obj18).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 264;
		lblNguoi_Gd.Text = "Người đề nghị";
		TextBox obj19 = txtNguoi_dn;
		location = new Point(131, 71);
		((Control)obj19).Location = location;
		((TextBoxBase)txtNguoi_dn).MaxLength = 30;
		((Control)txtNguoi_dn).Name = "txtNguoi_dn";
		TextBox obj20 = txtNguoi_dn;
		size = new Size(128, 20);
		((Control)obj20).Size = size;
		((Control)txtNguoi_dn).TabIndex = 4;
		((Control)gbCt).Anchor = (AnchorStyles)15;
		((Control)gbCt).Controls.Add((Control)(object)lblTen_bp);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_bp);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_bp);
		((Control)gbCt).Controls.Add((Control)(object)txtNgay_ct1);
		((Control)gbCt).Controls.Add((Control)(object)lblNguoi_Gd);
		((Control)gbCt).Controls.Add((Control)(object)Label4);
		((Control)gbCt).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbCt).Controls.Add((Control)(object)txtNguoi_dn);
		((Control)gbCt).Controls.Add((Control)(object)lblDien_giai);
		((Control)gbCt).Controls.Add((Control)(object)Label3);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Hd);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_Hd);
		((Control)gbCt).Controls.Add((Control)(object)txtNgay_ct2);
		((Control)gbCt).Controls.Add((Control)(object)Label2);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_Hd);
		((Control)gbCt).Controls.Add((Control)(object)Label1);
		((Control)gbCt).Controls.Add((Control)(object)txtSo_ct2);
		((Control)gbCt).Controls.Add((Control)(object)txtSo_ct1);
		GroupBox obj21 = gbCt;
		location = new Point(10, 3);
		((Control)obj21).Location = location;
		((Control)gbCt).Name = "gbCt";
		GroupBox obj22 = gbCt;
		size = new Size(563, 186);
		((Control)obj22).Size = size;
		((Control)gbCt).TabIndex = 0;
		gbCt.TabStop = false;
		lblTen_bp.ImeMode = (ImeMode)0;
		Label obj23 = lblTen_bp;
		location = new Point(219, 100);
		((Control)obj23).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj24 = lblTen_bp;
		size = new Size(320, 13);
		((Control)obj24).Size = size;
		((Control)lblTen_bp).TabIndex = 267;
		((TextBox)txtMa_bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = false;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_bp;
		location = new Point(131, 97);
		((Control)asTextBox3).Location = location;
		txtMa_bp.LookupCodeName = "MA_BP";
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		AsTextBox asTextBox4 = txtMa_bp;
		size = new Size(82, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_bp).TabIndex = 5;
		txtMa_bp.UseAutoCompleteSource = true;
		lblMa_bp.AutoSize = true;
		lblMa_bp.ImeMode = (ImeMode)0;
		Label obj25 = lblMa_bp;
		location = new Point(7, 100);
		((Control)obj25).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj26 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj26).Size = size;
		((Control)lblMa_bp).TabIndex = 266;
		lblMa_bp.Text = "Mã bộ phận";
		lblMa_bp.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(585, 227);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)gbCt);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Name = "frmPOVchPO1FindPO0";
		((Form)this).Text = "Chon PDN";
		((Control)gbCt).ResumeLayout(false);
		((Control)gbCt).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void cmdOk_Click(object sender, EventArgs e)
	{
		((Form)this).DialogResult = (DialogResult)1;
		sWhereKey = "Ma_Cty='" + CompanyInformations.CompanyID + "'";
		if (Operators.ConditionalCompareObjectNotEqual(txtNgay_ct1.Value, (object)new DateTime(599266080000000000L), false))
		{
			string text = sWhereKey;
			DateTime dateTime = (DateTime)txtNgay_ct1.Value;
			sWhereKey = text + " and Ngay_ct>= '" + dateTime.ToString("MM/dd/yyyy") + "'";
		}
		if (Operators.ConditionalCompareObjectNotEqual(txtNgay_ct2.Value, (object)new DateTime(599266080000000000L), false))
		{
			string text2 = sWhereKey;
			DateTime dateTime = (DateTime)txtNgay_ct2.Value;
			sWhereKey = text2 + " and Ngay_ct <= '" + dateTime.ToString("MM/dd/yyyy") + "'";
		}
		if (Operators.CompareString(txtSo_ct1.Text, "", false) != 0)
		{
			sWhereKey = sWhereKey + " and So_ct>= '" + txtSo_ct1.Text + "'";
		}
		if (Operators.CompareString(txtSo_ct2.Text, "", false) != 0)
		{
			sWhereKey = sWhereKey + " and So_ct<= '" + txtSo_ct2.Text + "'";
		}
		if (Operators.CompareString(((TextBox)txtMa_bp).Text, "", false) != 0)
		{
			sWhereKey = sWhereKey + " and ma_bp like '" + ((TextBox)txtMa_bp).Text + "%'";
		}
		if (Operators.CompareString(((TextBox)txtMa_Hd).Text, "", false) != 0)
		{
			sWhereKey = sWhereKey + " and ma_hd like '" + ((TextBox)txtMa_Hd).Text + "%'";
		}
		if (Operators.CompareString(txtNguoi_dn.Text, "", false) != 0)
		{
			sWhereKey = sWhereKey + " and Nguoi_dn like '" + txtNguoi_dn.Text + "%'";
		}
		if (Operators.CompareString(txtDien_giai.Text, "", false) != 0)
		{
			sWhereKey = sWhereKey + " and dien_giai like '%" + txtDien_giai.Text + "%'";
		}
		AsiaErp.Framework.Environment.set_PublicVariables("Ngay_Ct1", RuntimeHelpers.GetObjectValue(txtNgay_ct1.Value));
		AsiaErp.Framework.Environment.set_PublicVariables("Ngay_Ct2", RuntimeHelpers.GetObjectValue(txtNgay_ct2.Value));
		((Form)this).Close();
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		((Form)this).DialogResult = (DialogResult)2;
		((Form)this).Close();
	}

	private void frmArVchAr1FindSO3SO5_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).DialogResult = (DialogResult)2;
			((Form)this).Close();
		}
	}
}
