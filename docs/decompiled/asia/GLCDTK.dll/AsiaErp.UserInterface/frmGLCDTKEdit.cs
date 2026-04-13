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
public class frmGLCDTKEdit : frmOBEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_tk")]
	private AsTextBox _txtMa_tk;

	[AccessedThroughProperty("lblMa_tk")]
	private Label _lblMa_tk;

	[AccessedThroughProperty("lblTen_tk")]
	private Label _lblTen_tk;

	[AccessedThroughProperty("txtDu_no_dk")]
	private AsTextNumeric _txtDu_no_dk;

	[AccessedThroughProperty("lblTen_nt")]
	private Label _lblTen_nt;

	[AccessedThroughProperty("lblDu_no_dk")]
	private Label _lblDu_no_dk;

	[AccessedThroughProperty("lblMa_nt")]
	private Label _lblMa_nt;

	[AccessedThroughProperty("txtDu_co_dk")]
	private AsTextNumeric _txtDu_co_dk;

	[AccessedThroughProperty("lblDu_co_dk")]
	private Label _lblDu_co_dk;

	[AccessedThroughProperty("txtDu_co_dk_nt")]
	private AsTextNumeric _txtDu_co_dk_nt;

	[AccessedThroughProperty("txtDu_no_dk_nt")]
	private AsTextNumeric _txtDu_no_dk_nt;

	[AccessedThroughProperty("lblDu_co_dk_nt")]
	private Label _lblDu_co_dk_nt;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtYear")]
	private AsTextNumeric _txtYear;

	[AccessedThroughProperty("lblYear")]
	private Label _lblYear;

	[AccessedThroughProperty("txtDu_co_dn_nt")]
	private AsTextNumeric _txtDu_co_dn_nt;

	[AccessedThroughProperty("txtDu_co_dn")]
	private AsTextNumeric _txtDu_co_dn;

	[AccessedThroughProperty("txtDu_no_dn_nt")]
	private AsTextNumeric _txtDu_no_dn_nt;

	[AccessedThroughProperty("txtDu_no_dn")]
	private AsTextNumeric _txtDu_no_dn;

	[AccessedThroughProperty("lblDu_co_dn_nt")]
	private Label _lblDu_co_dn_nt;

	[AccessedThroughProperty("lblDu_co_dn")]
	private Label _lblDu_co_dn;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("lblDu_no_dn")]
	private Label _lblDu_no_dn;

	[AccessedThroughProperty("txtMa_nt")]
	private TextBox _txtMa_nt;

	private int intMonth;

	private bool isTkCn;

	internal virtual AsTextBox txtMa_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_tk_AfterCodeValidating;
			if (_txtMa_tk != null)
			{
				_txtMa_tk.AfterCodeValidating -= obj;
			}
			_txtMa_tk = value;
			if (_txtMa_tk != null)
			{
				_txtMa_tk.AfterCodeValidating += obj;
			}
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

	internal virtual AsTextNumeric txtDu_no_dk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_no_dk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtDu_no_dk_Validated;
			if (_txtDu_no_dk != null)
			{
				((Control)_txtDu_no_dk).Validated -= eventHandler;
			}
			_txtDu_no_dk = value;
			if (_txtDu_no_dk != null)
			{
				((Control)_txtDu_no_dk).Validated += eventHandler;
			}
		}
	}

	internal virtual Label lblTen_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nt = value;
		}
	}

	internal virtual Label lblDu_no_dk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDu_no_dk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDu_no_dk = value;
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

	internal virtual AsTextNumeric txtDu_co_dk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_co_dk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtDu_co_dk_Validated;
			if (_txtDu_co_dk != null)
			{
				((Control)_txtDu_co_dk).Validated -= eventHandler;
			}
			_txtDu_co_dk = value;
			if (_txtDu_co_dk != null)
			{
				((Control)_txtDu_co_dk).Validated += eventHandler;
			}
		}
	}

	internal virtual Label lblDu_co_dk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDu_co_dk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDu_co_dk = value;
		}
	}

	internal virtual AsTextNumeric txtDu_co_dk_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_co_dk_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtDu_co_dk_nt_Validated;
			if (_txtDu_co_dk_nt != null)
			{
				((Control)_txtDu_co_dk_nt).Validated -= eventHandler;
			}
			_txtDu_co_dk_nt = value;
			if (_txtDu_co_dk_nt != null)
			{
				((Control)_txtDu_co_dk_nt).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtDu_no_dk_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_no_dk_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtDu_no_dk_nt_Validated;
			if (_txtDu_no_dk_nt != null)
			{
				((Control)_txtDu_no_dk_nt).Validated -= eventHandler;
			}
			_txtDu_no_dk_nt = value;
			if (_txtDu_no_dk_nt != null)
			{
				((Control)_txtDu_no_dk_nt).Validated += eventHandler;
			}
		}
	}

	internal virtual Label lblDu_co_dk_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDu_co_dk_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDu_co_dk_nt = value;
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

	internal virtual AsTextNumeric txtYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtYear = value;
		}
	}

	internal virtual Label lblYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblYear = value;
		}
	}

	internal virtual AsTextNumeric txtDu_co_dn_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_co_dn_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtDu_co_dn_nt_Validated;
			if (_txtDu_co_dn_nt != null)
			{
				((Control)_txtDu_co_dn_nt).Validated -= eventHandler;
			}
			_txtDu_co_dn_nt = value;
			if (_txtDu_co_dn_nt != null)
			{
				((Control)_txtDu_co_dn_nt).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtDu_co_dn
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_co_dn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtDu_co_dn_Validated;
			if (_txtDu_co_dn != null)
			{
				((Control)_txtDu_co_dn).Validated -= eventHandler;
			}
			_txtDu_co_dn = value;
			if (_txtDu_co_dn != null)
			{
				((Control)_txtDu_co_dn).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtDu_no_dn_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_no_dn_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtDu_no_dn_nt_Validated;
			if (_txtDu_no_dn_nt != null)
			{
				((Control)_txtDu_no_dn_nt).Validated -= eventHandler;
			}
			_txtDu_no_dn_nt = value;
			if (_txtDu_no_dn_nt != null)
			{
				((Control)_txtDu_no_dn_nt).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtDu_no_dn
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_no_dn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtDu_no_dn_Validated;
			if (_txtDu_no_dn != null)
			{
				((Control)_txtDu_no_dn).Validated -= eventHandler;
			}
			_txtDu_no_dn = value;
			if (_txtDu_no_dn != null)
			{
				((Control)_txtDu_no_dn).Validated += eventHandler;
			}
		}
	}

	internal virtual Label lblDu_co_dn_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDu_co_dn_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDu_co_dn_nt = value;
		}
	}

	internal virtual Label lblDu_co_dn
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDu_co_dn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDu_co_dn = value;
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

	internal virtual Label lblDu_no_dn
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDu_no_dn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDu_no_dn = value;
		}
	}

	internal virtual TextBox txtMa_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nt = value;
		}
	}

	public frmGLCDTKEdit()
	{
		__ENCAddToList(this);
		intMonth = 0;
		isTkCn = false;
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
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
		lblMa_tk = new Label();
		txtMa_tk = new AsTextBox();
		lblTen_tk = new Label();
		lblTen_nt = new Label();
		lblMa_nt = new Label();
		txtDu_no_dk = new AsTextNumeric();
		lblDu_no_dk = new Label();
		lblDu_co_dk = new Label();
		txtDu_co_dk = new AsTextNumeric();
		Label1 = new Label();
		lblDu_co_dk_nt = new Label();
		txtDu_no_dk_nt = new AsTextNumeric();
		txtDu_co_dk_nt = new AsTextNumeric();
		txtYear = new AsTextNumeric();
		lblYear = new Label();
		txtDu_no_dn_nt = new AsTextNumeric();
		txtDu_co_dn = new AsTextNumeric();
		txtDu_no_dn = new AsTextNumeric();
		lblDu_co_dn_nt = new Label();
		txtDu_co_dn_nt = new AsTextNumeric();
		lblDu_co_dn = new Label();
		Label3 = new Label();
		lblDu_no_dn = new Label();
		txtMa_nt = new TextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(21, 344);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 24;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 216);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 216);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtMa_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtYear);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_co_dn_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_co_dk_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_co_dn);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_co_dk);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_no_dn_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_no_dk_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_no_dn);
		((Control)gbLine).Controls.Add((Control)(object)lblDu_co_dn_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_no_dk);
		((Control)gbLine).Controls.Add((Control)(object)lblDu_co_dk_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblDu_co_dn);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)lblDu_co_dk);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)lblDu_no_dn);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_tk);
		((Control)gbLine).Controls.Add((Control)(object)lblDu_no_dk);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblYear);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_tk);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tk);
		GroupBox obj3 = gbLine;
		Size size = new Size(485, 204);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblYear, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDu_no_dk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDu_no_dn, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDu_co_dk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDu_co_dn, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDu_co_dk_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDu_no_dk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDu_co_dn_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDu_no_dn, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDu_no_dk_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDu_no_dn_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDu_co_dk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDu_co_dn, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDu_co_dk_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDu_co_dn_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtYear, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		lblMa_tk.AutoSize = true;
		Label obj4 = lblMa_tk;
		location = new Point(18, 47);
		((Control)obj4).Location = location;
		((Control)lblMa_tk).Name = "lblMa_tk";
		Label obj5 = lblMa_tk;
		size = new Size(39, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_tk).TabIndex = 14;
		lblMa_tk.Text = "Mã TK";
		txtMa_tk.AutoLookup = true;
		txtMa_tk.AutoValid = true;
		((TextBoxBase)txtMa_tk).BackColor = SystemColors.Info;
		((TextBox)txtMa_tk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_tk;
		location = new Point(97, 43);
		((Control)asTextBox).Location = location;
		txtMa_tk.LookupCodeName = "TK";
		txtMa_tk.LookupWhereCondition = "TK_CN <> 1 AND TK_ME <> ''";
		((Control)txtMa_tk).Name = "txtMa_tk";
		txtMa_tk.NameControl = lblTen_tk;
		AsTextBox asTextBox2 = txtMa_tk;
		size = new Size(59, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_tk).TabIndex = 0;
		txtMa_tk.UseAutoCompleteSource = true;
		txtMa_tk.ValidReturnFieldList = "TK,MA_NT";
		Label obj6 = lblTen_tk;
		location = new Point(165, 47);
		((Control)obj6).Location = location;
		((Control)lblTen_tk).Name = "lblTen_tk";
		Label obj7 = lblTen_tk;
		size = new Size(279, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_tk).TabIndex = 11;
		Label obj8 = lblTen_nt;
		location = new Point(165, 72);
		((Control)obj8).Location = location;
		((Control)lblTen_nt).Name = "lblTen_nt";
		Label obj9 = lblTen_nt;
		size = new Size(305, 13);
		((Control)obj9).Size = size;
		((Control)lblTen_nt).TabIndex = 10;
		lblMa_nt.AutoSize = true;
		Label obj10 = lblMa_nt;
		location = new Point(18, 72);
		((Control)obj10).Location = location;
		((Control)lblMa_nt).Name = "lblMa_nt";
		Label obj11 = lblMa_nt;
		size = new Size(40, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_nt).TabIndex = 15;
		lblMa_nt.Text = "Mã NT";
		txtDu_no_dk.DecimalSymbol = ".";
		txtDu_no_dk.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtDu_no_dk;
		location = new Point(97, 93);
		((Control)asTextNumeric).Location = location;
		txtDu_no_dk.Mask = "### ### ### ###";
		((Control)txtDu_no_dk).Name = "txtDu_no_dk";
		AsTextNumeric asTextNumeric2 = txtDu_no_dk;
		size = new Size(105, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtDu_no_dk).TabIndex = 1;
		((TextBox)txtDu_no_dk).Text = "0";
		((TextBox)txtDu_no_dk).TextAlign = (HorizontalAlignment)1;
		txtDu_no_dk.Value = 0;
		lblDu_no_dk.AutoSize = true;
		Label obj12 = lblDu_no_dk;
		location = new Point(18, 97);
		((Control)obj12).Location = location;
		((Control)lblDu_no_dk).Name = "lblDu_no_dk";
		Label obj13 = lblDu_no_dk;
		size = new Size(54, 13);
		((Control)obj13).Size = size;
		((Control)lblDu_no_dk).TabIndex = 16;
		lblDu_no_dk.Text = "Dư nợ ĐK";
		lblDu_co_dk.AutoSize = true;
		Label obj14 = lblDu_co_dk;
		location = new Point(18, 122);
		((Control)obj14).Location = location;
		((Control)lblDu_co_dk).Name = "lblDu_co_dk";
		Label obj15 = lblDu_co_dk;
		size = new Size(54, 13);
		((Control)obj15).Size = size;
		((Control)lblDu_co_dk).TabIndex = 17;
		lblDu_co_dk.Text = "Dư có ĐK";
		txtDu_co_dk.DecimalSymbol = ".";
		txtDu_co_dk.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtDu_co_dk;
		location = new Point(97, 118);
		((Control)asTextNumeric3).Location = location;
		txtDu_co_dk.Mask = "### ### ### ###";
		((Control)txtDu_co_dk).Name = "txtDu_co_dk";
		AsTextNumeric asTextNumeric4 = txtDu_co_dk;
		size = new Size(105, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtDu_co_dk).TabIndex = 2;
		((TextBox)txtDu_co_dk).Text = "0";
		((TextBox)txtDu_co_dk).TextAlign = (HorizontalAlignment)1;
		txtDu_co_dk.Value = 0;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(18, 147);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(72, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 18;
		Label1.Text = "Dư nợ ĐK NT";
		lblDu_co_dk_nt.AutoSize = true;
		Label obj16 = lblDu_co_dk_nt;
		location = new Point(18, 173);
		((Control)obj16).Location = location;
		((Control)lblDu_co_dk_nt).Name = "lblDu_co_dk_nt";
		Label obj17 = lblDu_co_dk_nt;
		size = new Size(72, 13);
		((Control)obj17).Size = size;
		((Control)lblDu_co_dk_nt).TabIndex = 19;
		lblDu_co_dk_nt.Text = "Dư có ĐK NT";
		txtDu_no_dk_nt.DecimalSymbol = ".";
		txtDu_no_dk_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtDu_no_dk_nt;
		location = new Point(97, 143);
		((Control)asTextNumeric5).Location = location;
		txtDu_no_dk_nt.Mask = "### ### ### ###.##";
		((Control)txtDu_no_dk_nt).Name = "txtDu_no_dk_nt";
		AsTextNumeric asTextNumeric6 = txtDu_no_dk_nt;
		size = new Size(105, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtDu_no_dk_nt).TabIndex = 3;
		((TextBox)txtDu_no_dk_nt).Text = "0.00";
		((TextBox)txtDu_no_dk_nt).TextAlign = (HorizontalAlignment)1;
		txtDu_no_dk_nt.Value = 0;
		txtDu_co_dk_nt.DecimalSymbol = ".";
		txtDu_co_dk_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtDu_co_dk_nt;
		location = new Point(97, 169);
		((Control)asTextNumeric7).Location = location;
		txtDu_co_dk_nt.Mask = "### ### ### ###.##";
		((Control)txtDu_co_dk_nt).Name = "txtDu_co_dk_nt";
		AsTextNumeric asTextNumeric8 = txtDu_co_dk_nt;
		size = new Size(105, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtDu_co_dk_nt).TabIndex = 4;
		((TextBox)txtDu_co_dk_nt).Text = "0.00";
		((TextBox)txtDu_co_dk_nt).TextAlign = (HorizontalAlignment)1;
		txtDu_co_dk_nt.Value = 0;
		txtYear.DecimalSymbol = ".";
		txtYear.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric9 = txtYear;
		location = new Point(97, 18);
		((Control)asTextNumeric9).Location = location;
		txtYear.Mask = "####";
		((Control)txtYear).Name = "txtYear";
		((TextBoxBase)txtYear).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtYear;
		size = new Size(59, 20);
		((Control)asTextNumeric10).Size = size;
		((Control)txtYear).TabIndex = 12;
		((Control)txtYear).TabStop = false;
		((TextBox)txtYear).Text = "0";
		((TextBox)txtYear).TextAlign = (HorizontalAlignment)1;
		txtYear.Value = 0;
		lblYear.AutoSize = true;
		Label obj18 = lblYear;
		location = new Point(18, 22);
		((Control)obj18).Location = location;
		((Control)lblYear).Name = "lblYear";
		Label obj19 = lblYear;
		size = new Size(29, 13);
		((Control)obj19).Size = size;
		((Control)lblYear).TabIndex = 13;
		lblYear.Text = "Năm";
		txtDu_no_dn_nt.DecimalSymbol = ".";
		txtDu_no_dn_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric11 = txtDu_no_dn_nt;
		location = new Point(357, 141);
		((Control)asTextNumeric11).Location = location;
		txtDu_no_dn_nt.Mask = "### ### ### ###.##";
		((Control)txtDu_no_dn_nt).Name = "txtDu_no_dn_nt";
		AsTextNumeric asTextNumeric12 = txtDu_no_dn_nt;
		size = new Size(105, 20);
		((Control)asTextNumeric12).Size = size;
		((Control)txtDu_no_dn_nt).TabIndex = 7;
		((TextBox)txtDu_no_dn_nt).Text = "0.00";
		((TextBox)txtDu_no_dn_nt).TextAlign = (HorizontalAlignment)1;
		txtDu_no_dn_nt.Value = 0;
		txtDu_co_dn.DecimalSymbol = ".";
		txtDu_co_dn.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric13 = txtDu_co_dn;
		location = new Point(357, 116);
		((Control)asTextNumeric13).Location = location;
		txtDu_co_dn.Mask = "### ### ### ###";
		((Control)txtDu_co_dn).Name = "txtDu_co_dn";
		AsTextNumeric asTextNumeric14 = txtDu_co_dn;
		size = new Size(105, 20);
		((Control)asTextNumeric14).Size = size;
		((Control)txtDu_co_dn).TabIndex = 6;
		((TextBox)txtDu_co_dn).Text = "0";
		((TextBox)txtDu_co_dn).TextAlign = (HorizontalAlignment)1;
		txtDu_co_dn.Value = 0;
		txtDu_no_dn.DecimalSymbol = ".";
		txtDu_no_dn.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric15 = txtDu_no_dn;
		location = new Point(357, 90);
		((Control)asTextNumeric15).Location = location;
		txtDu_no_dn.Mask = "### ### ### ###";
		((Control)txtDu_no_dn).Name = "txtDu_no_dn";
		AsTextNumeric asTextNumeric16 = txtDu_no_dn;
		size = new Size(105, 20);
		((Control)asTextNumeric16).Size = size;
		((Control)txtDu_no_dn).TabIndex = 5;
		((TextBox)txtDu_no_dn).Text = "0";
		((TextBox)txtDu_no_dn).TextAlign = (HorizontalAlignment)1;
		txtDu_no_dn.Value = 0;
		lblDu_co_dn_nt.AutoSize = true;
		Label obj20 = lblDu_co_dn_nt;
		location = new Point(278, 171);
		((Control)obj20).Location = location;
		((Control)lblDu_co_dn_nt).Name = "lblDu_co_dn_nt";
		Label obj21 = lblDu_co_dn_nt;
		size = new Size(73, 13);
		((Control)obj21).Size = size;
		((Control)lblDu_co_dn_nt).TabIndex = 23;
		lblDu_co_dn_nt.Text = "Dư có ĐN NT";
		txtDu_co_dn_nt.DecimalSymbol = ".";
		txtDu_co_dn_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric17 = txtDu_co_dn_nt;
		location = new Point(357, 167);
		((Control)asTextNumeric17).Location = location;
		txtDu_co_dn_nt.Mask = "### ### ### ###.##";
		((Control)txtDu_co_dn_nt).Name = "txtDu_co_dn_nt";
		AsTextNumeric asTextNumeric18 = txtDu_co_dn_nt;
		size = new Size(105, 20);
		((Control)asTextNumeric18).Size = size;
		((Control)txtDu_co_dn_nt).TabIndex = 8;
		((TextBox)txtDu_co_dn_nt).Text = "0.00";
		((TextBox)txtDu_co_dn_nt).TextAlign = (HorizontalAlignment)1;
		txtDu_co_dn_nt.Value = 0;
		lblDu_co_dn.AutoSize = true;
		Label obj22 = lblDu_co_dn;
		location = new Point(278, 120);
		((Control)obj22).Location = location;
		((Control)lblDu_co_dn).Name = "lblDu_co_dn";
		Label obj23 = lblDu_co_dn;
		size = new Size(55, 13);
		((Control)obj23).Size = size;
		((Control)lblDu_co_dn).TabIndex = 21;
		lblDu_co_dn.Text = "Dư có ĐN";
		Label3.AutoSize = true;
		Label label3 = Label3;
		location = new Point(278, 145);
		((Control)label3).Location = location;
		((Control)Label3).Name = "Label3";
		Label label4 = Label3;
		size = new Size(73, 13);
		((Control)label4).Size = size;
		((Control)Label3).TabIndex = 22;
		Label3.Text = "Dư nợ ĐN NT";
		lblDu_no_dn.AutoSize = true;
		Label obj24 = lblDu_no_dn;
		location = new Point(278, 94);
		((Control)obj24).Location = location;
		((Control)lblDu_no_dn).Name = "lblDu_no_dn";
		Label obj25 = lblDu_no_dn;
		size = new Size(55, 13);
		((Control)obj25).Size = size;
		((Control)lblDu_no_dn).TabIndex = 20;
		lblDu_no_dn.Text = "Dư nợ ĐN";
		TextBox obj26 = txtMa_nt;
		location = new Point(97, 68);
		((Control)obj26).Location = location;
		((Control)txtMa_nt).Name = "txtMa_nt";
		((TextBoxBase)txtMa_nt).ReadOnly = true;
		TextBox obj27 = txtMa_nt;
		size = new Size(59, 20);
		((Control)obj27).Size = size;
		((Control)txtMa_nt).TabIndex = 25;
		((Control)txtMa_nt).TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(509, 251);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGLCDTKEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		FormatTextNumeric();
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			txtYear.Value = SystemInformations.FinancialYear;
		}
		intMonth = Conversions.ToInteger(AsiaErp.Framework.Environment.get_PublicVariables("g_intMonth4GLCDTKEdit"));
		isTkCn = Conversions.ToBoolean(AsiaErp.Framework.Environment.get_PublicVariables("g_tkcn4GLCDTKEdit"));
		EnableCo_No_Dk();
		EnableCo_No_Dn();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_tk).Enabled = false;
		((Control)txtMa_nt).Enabled = false;
	}

	protected override void DataBinding()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_tk;
		CreateDataBinding(ref ojb, "tk");
		txtMa_tk = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtYear;
		CreateDataBinding(ref ojb, "nam", "Value");
		txtYear = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtMa_nt;
		CreateDataBinding(ref ojb, "ma_nt");
		txtMa_nt = (TextBox)ojb;
		ojb = (Control)(object)txtDu_co_dk;
		CreateDataBinding(ref ojb, "du_co", "Value");
		txtDu_co_dk = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDu_co_dk_nt;
		CreateDataBinding(ref ojb, "du_co_nt", "Value");
		txtDu_co_dk_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDu_co_dn;
		CreateDataBinding(ref ojb, "du_co00", "Value");
		txtDu_co_dn = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDu_co_dn_nt;
		CreateDataBinding(ref ojb, "du_co_nt00", "Value");
		txtDu_co_dn_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDu_no_dk;
		CreateDataBinding(ref ojb, "du_no", "Value");
		txtDu_no_dk = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDu_no_dk_nt;
		CreateDataBinding(ref ojb, "du_no_nt", "Value");
		txtDu_no_dk_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDu_no_dn;
		CreateDataBinding(ref ojb, "du_no00", "Value");
		txtDu_no_dn = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDu_no_dn_nt;
		CreateDataBinding(ref ojb, "du_no_nt00", "Value");
		txtDu_no_dn_nt = (AsTextNumeric)(object)ojb;
	}

	protected override bool ValidData()
	{
		return (ChkEmtyTextBox((TextBox)(object)txtMa_tk) && base.ValidData()) ? true : false;
	}

	protected override bool SetToRow()
	{
		base.SetToRow();
		RowToEdit["luser"] = SystemInformations.UserName;
		bool result = default(bool);
		return result;
	}

	private void FormatTextNumeric()
	{
		txtDu_no_dk.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		txtDu_co_dk.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		txtDu_no_dn.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		txtDu_co_dn.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		txtDu_no_dk_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
		txtDu_co_dk_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
		txtDu_no_dn_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
		txtDu_co_dn_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
	}

	private void EnableCo_No_Dn()
	{
		if (intMonth == 1)
		{
			((Control)txtDu_co_dn).Enabled = false;
			((Control)txtDu_no_dn).Enabled = false;
			((Control)txtDu_no_dn_nt).Enabled = false;
			((Control)txtDu_co_dn_nt).Enabled = false;
			return;
		}
		((Control)txtDu_co_dn).Enabled = true;
		((Control)txtDu_no_dn).Enabled = true;
		if ((Operators.CompareString(txtMa_nt.Text.Trim(), "", false) != 0 && Operators.CompareString(txtMa_nt.Text, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) != 0) ? true : false)
		{
			((Control)txtDu_no_dn_nt).Enabled = true;
			((Control)txtDu_co_dn_nt).Enabled = true;
		}
		else
		{
			((Control)txtDu_no_dn_nt).Enabled = false;
			((Control)txtDu_co_dn_nt).Enabled = false;
		}
	}

	private void EnableCo_No_Dk()
	{
		if ((Operators.CompareString(txtMa_nt.Text.Trim(), "", false) != 0 && Operators.CompareString(txtMa_nt.Text, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) != 0) ? true : false)
		{
			((Control)txtDu_no_dk_nt).Enabled = true;
			((Control)txtDu_co_dk_nt).Enabled = true;
		}
		else
		{
			((Control)txtDu_no_dk_nt).Enabled = false;
			((Control)txtDu_co_dk_nt).Enabled = false;
		}
		if (isTkCn)
		{
			((Control)txtDu_no_dk_nt).Enabled = false;
			((Control)txtDu_co_dk_nt).Enabled = false;
			((Control)txtDu_no_dk).Enabled = false;
			((Control)txtDu_co_dk).Enabled = false;
		}
	}

	private void txtDu_no_dk_Validated(object sender, EventArgs e)
	{
		if ((Operators.ConditionalCompareObjectNotEqual(txtDu_no_dk.Value, (object)0, false) && !isTkCn) ? true : false)
		{
			txtDu_co_dk.Value = 0;
			txtDu_co_dk_Validated(RuntimeHelpers.GetObjectValue(sender), e);
		}
		if (intMonth == 1)
		{
			txtDu_no_dn.Value = RuntimeHelpers.GetObjectValue(txtDu_no_dk.Value);
		}
	}

	private void txtDu_co_dk_nt_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtDu_co_dk_nt.Value, (object)0, false))
		{
			txtDu_no_dk_nt.Value = 0;
			txtDu_no_dk_nt_Validated(RuntimeHelpers.GetObjectValue(sender), e);
		}
		if (intMonth == 1)
		{
			txtDu_co_dn_nt.Value = RuntimeHelpers.GetObjectValue(txtDu_co_dk_nt.Value);
		}
	}

	private void txtDu_no_dk_nt_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtDu_no_dk_nt.Value, (object)0, false))
		{
			txtDu_co_dk_nt.Value = 0;
			txtDu_co_dk_nt_Validated(RuntimeHelpers.GetObjectValue(sender), e);
		}
		if (intMonth == 1)
		{
			txtDu_no_dn_nt.Value = RuntimeHelpers.GetObjectValue(txtDu_no_dk_nt.Value);
		}
	}

	private void txtDu_co_dk_Validated(object sender, EventArgs e)
	{
		if ((Operators.ConditionalCompareObjectNotEqual(txtDu_co_dk.Value, (object)0, false) && !isTkCn) ? true : false)
		{
			txtDu_no_dk.Value = 0;
			txtDu_no_dk_Validated(RuntimeHelpers.GetObjectValue(sender), e);
		}
		if (intMonth == 1)
		{
			txtDu_co_dn.Value = RuntimeHelpers.GetObjectValue(txtDu_co_dk.Value);
		}
	}

	private void txtDu_no_dn_Validated(object sender, EventArgs e)
	{
		if ((Operators.ConditionalCompareObjectNotEqual(txtDu_no_dn.Value, (object)0, false) && !isTkCn) ? true : false)
		{
			txtDu_co_dn.Value = 0;
		}
	}

	private void txtDu_co_dn_Validated(object sender, EventArgs e)
	{
		if ((Operators.ConditionalCompareObjectNotEqual(txtDu_co_dn.Value, (object)0, false) && !isTkCn) ? true : false)
		{
			txtDu_no_dn.Value = 0;
		}
	}

	private void txtDu_no_dn_nt_Validated(object sender, EventArgs e)
	{
		if ((Operators.ConditionalCompareObjectNotEqual(txtDu_no_dn_nt.Value, (object)0, false) && !isTkCn) ? true : false)
		{
			txtDu_co_dn_nt.Value = 0;
		}
	}

	private void txtDu_co_dn_nt_Validated(object sender, EventArgs e)
	{
		if ((Operators.ConditionalCompareObjectNotEqual(txtDu_co_dn_nt.Value, (object)0, false) && !isTkCn) ? true : false)
		{
			txtDu_no_dn_nt.Value = 0;
		}
	}

	private void txtMa_tk_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		txtMa_nt.Text = Conversions.ToString(e.ValidatedRow["ma_nt"]);
		EnableCo_No_Dk();
		EnableCo_No_Dn();
	}
}
