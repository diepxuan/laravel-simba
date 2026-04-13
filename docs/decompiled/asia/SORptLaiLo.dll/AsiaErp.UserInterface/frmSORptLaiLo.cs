using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSORptLaiLo : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblTen_HD")]
	private Label _lblTen_HD;

	[AccessedThroughProperty("lblMa_TD")]
	private Label _lblMa_TD;

	[AccessedThroughProperty("txtMa_HD")]
	private AsTextBox _txtMa_HD;

	[AccessedThroughProperty("lblMa_KH")]
	private Label _lblMa_KH;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtMa_KH")]
	private AsTextBox _txtMa_KH;

	[AccessedThroughProperty("txtTk_DT")]
	private AsTextBoxMulti _txtTk_DT;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("chkNC_DT")]
	private CheckBox _chkNC_DT;

	[AccessedThroughProperty("txtTkDu_DT")]
	private AsTextBoxMulti _txtTkDu_DT;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("chkNc_CP")]
	private CheckBox _chkNc_CP;

	[AccessedThroughProperty("txtTkDu_CP")]
	private AsTextBoxMulti _txtTkDu_CP;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtTk_Cp")]
	private AsTextBoxMulti _txtTk_Cp;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("rbCP_No")]
	private RadioButton _rbCP_No;

	[AccessedThroughProperty("rbCP_CO")]
	private RadioButton _rbCP_CO;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("rbDT_No")]
	private RadioButton _rbDT_No;

	[AccessedThroughProperty("rbDS_Co")]
	private RadioButton _rbDS_Co;

	internal virtual Label lblTen_HD
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_HD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_HD = value;
		}
	}

	internal virtual Label lblMa_TD
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_TD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_TD = value;
		}
	}

	internal virtual AsTextBox txtMa_HD
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_HD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_HD = value;
		}
	}

	internal virtual Label lblMa_KH
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_KH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_KH = value;
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

	internal virtual AsTextBox txtMa_KH
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_KH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_KH = value;
		}
	}

	internal virtual AsTextBoxMulti txtTk_DT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_DT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_DT = value;
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

	internal virtual CheckBox chkNC_DT
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkNC_DT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkNC_DT = value;
		}
	}

	internal virtual AsTextBoxMulti txtTkDu_DT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTkDu_DT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTkDu_DT = value;
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

	internal virtual CheckBox chkNc_CP
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkNc_CP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkNc_CP = value;
		}
	}

	internal virtual AsTextBoxMulti txtTkDu_CP
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTkDu_CP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTkDu_CP = value;
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

	internal virtual AsTextBoxMulti txtTk_Cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_Cp = value;
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

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel2 = value;
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

	internal virtual RadioButton rbCP_No
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbCP_No;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tbCP_No_CheckedChanged;
			if (_rbCP_No != null)
			{
				_rbCP_No.CheckedChanged -= eventHandler;
			}
			_rbCP_No = value;
			if (_rbCP_No != null)
			{
				_rbCP_No.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton rbCP_CO
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbCP_CO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rbCP_CO = value;
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

	internal virtual RadioButton rbDT_No
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbDT_No;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = rbDT_No_CheckedChanged;
			if (_rbDT_No != null)
			{
				_rbDT_No.CheckedChanged -= eventHandler;
			}
			_rbDT_No = value;
			if (_rbDT_No != null)
			{
				_rbDT_No.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton rbDS_Co
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbDS_Co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rbDS_Co = value;
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
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
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
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_163c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1646: Expected O, but got Unknown
		lblTen_HD = new Label();
		lblMa_TD = new Label();
		txtMa_HD = new AsTextBox();
		lblMa_KH = new Label();
		Label4 = new Label();
		txtMa_KH = new AsTextBox();
		Label1 = new Label();
		txtTk_DT = new AsTextBoxMulti();
		txtTkDu_DT = new AsTextBoxMulti();
		Label2 = new Label();
		chkNC_DT = new CheckBox();
		chkNc_CP = new CheckBox();
		txtTkDu_CP = new AsTextBoxMulti();
		Label3 = new Label();
		txtTk_Cp = new AsTextBoxMulti();
		Label5 = new Label();
		rbDT_No = new RadioButton();
		rbDS_Co = new RadioButton();
		Panel1 = new Panel();
		Label6 = new Label();
		Panel2 = new Panel();
		Label7 = new Label();
		rbCP_No = new RadioButton();
		rbCP_CO = new RadioButton();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(685, 460);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)Panel2);
		((Control)tabFilter).Controls.Add((Control)(object)Panel1);
		((Control)tabFilter).Controls.Add((Control)(object)chkNc_CP);
		((Control)tabFilter).Controls.Add((Control)(object)txtTkDu_CP);
		((Control)tabFilter).Controls.Add((Control)(object)Label3);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk_Cp);
		((Control)tabFilter).Controls.Add((Control)(object)Label5);
		((Control)tabFilter).Controls.Add((Control)(object)chkNC_DT);
		((Control)tabFilter).Controls.Add((Control)(object)txtTkDu_DT);
		((Control)tabFilter).Controls.Add((Control)(object)Label2);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk_DT);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_KH);
		((Control)tabFilter).Controls.Add((Control)(object)Label4);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_KH);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_HD);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_TD);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_HD);
		TabPage obj = tabFilter;
		size = new Size(677, 431);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_HD, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_TD, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_HD, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_KH, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_KH, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk_DT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTkDu_DT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)chkNC_DT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk_Cp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTkDu_CP, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)chkNc_CP, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Panel1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Panel2, 0);
		Button obj2 = cmdExcel;
		Point location = new Point(657, 314);
		((Control)obj2).Location = location;
		((Control)cmdExcel).TabIndex = 23;
		((Control)txtNgay2).TabIndex = 5;
		Button obj3 = cmdCancel;
		location = new Point(576, 314);
		((Control)obj3).Location = location;
		((Control)cmdCancel).TabIndex = 22;
		((Control)cmdModifyReport).TabIndex = 1;
		((Control)txtNgay1).TabIndex = 4;
		((Control)cboKyBc).TabIndex = 3;
		Label obj4 = lblKyBc;
		location = new Point(18, 82);
		((Control)obj4).Location = location;
		Label obj5 = lblMau_bc;
		location = new Point(18, 28);
		((Control)obj5).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 261);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 14;
		Label obj6 = lblMauBC;
		location = new Point(155, 265);
		((Control)obj6).Location = location;
		((Control)lblMauBC).TabIndex = 13;
		RadioButton obj7 = optVND;
		location = new Point(233, 263);
		((Control)obj7).Location = location;
		((Control)optVND).TabIndex = 15;
		RadioButton obj8 = optNt;
		location = new Point(287, 263);
		((Control)obj8).Location = location;
		((Control)optNt).TabIndex = 16;
		Label obj9 = lblMa_nt;
		location = new Point(18, 264);
		((Control)obj9).Location = location;
		((Control)lblMa_nt).TabIndex = 11;
		Button obj10 = cmdOk;
		location = new Point(15, 304);
		((Control)obj10).Location = location;
		((Control)cmdOk).TabIndex = 17;
		Label obj11 = lblTieu_de;
		location = new Point(18, 55);
		((Control)obj11).Location = location;
		((Control)lblTieu_de).TabIndex = 14;
		((Control)txtTieu_De).TabIndex = 2;
		TabPage obj12 = tabGrid;
		size = new Size(677, 431);
		((Control)obj12).Size = size;
		Label obj13 = lblTen_HD;
		location = new Point(206, 108);
		((Control)obj13).Location = location;
		((Control)lblTen_HD).Name = "lblTen_HD";
		Label obj14 = lblTen_HD;
		size = new Size(339, 13);
		((Control)obj14).Size = size;
		((Control)lblTen_HD).TabIndex = 1039;
		lblMa_TD.AutoSize = true;
		Label obj15 = lblMa_TD;
		location = new Point(18, 108);
		((Control)obj15).Location = location;
		((Control)lblMa_TD).Name = "lblMa_TD";
		Label obj16 = lblMa_TD;
		size = new Size(41, 13);
		((Control)obj16).Size = size;
		((Control)lblMa_TD).TabIndex = 1036;
		lblMa_TD.Text = "Mã HĐ";
		txtMa_HD.AutoLookup = true;
		txtMa_HD.AutoValid = false;
		((TextBoxBase)txtMa_HD).BackColor = SystemColors.Info;
		((TextBox)txtMa_HD).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_HD;
		location = new Point(110, 105);
		((Control)asTextBox2).Location = location;
		txtMa_HD.LookupCodeName = "Ma_HD";
		((Control)txtMa_HD).Name = "txtMa_HD";
		txtMa_HD.NameControl = lblTen_HD;
		AsTextBox asTextBox3 = txtMa_HD;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_HD).TabIndex = 6;
		txtMa_HD.UseAutoCompleteSource = true;
		Label obj17 = lblMa_KH;
		location = new Point(206, 134);
		((Control)obj17).Location = location;
		((Control)lblMa_KH).Name = "lblMa_KH";
		Label obj18 = lblMa_KH;
		size = new Size(339, 13);
		((Control)obj18).Size = size;
		((Control)lblMa_KH).TabIndex = 1042;
		Label4.AutoSize = true;
		Label label = Label4;
		location = new Point(18, 134);
		((Control)label).Location = location;
		((Control)Label4).Name = "Label4";
		Label label2 = Label4;
		size = new Size(40, 13);
		((Control)label2).Size = size;
		((Control)Label4).TabIndex = 1041;
		Label4.Text = "Mã KH";
		txtMa_KH.AutoLookup = true;
		txtMa_KH.AutoValid = true;
		((TextBoxBase)txtMa_KH).BackColor = SystemColors.Info;
		((TextBox)txtMa_KH).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_KH;
		location = new Point(110, 131);
		((Control)asTextBox4).Location = location;
		txtMa_KH.LookupCodeName = "Ma_KH";
		((Control)txtMa_KH).Name = "txtMa_KH";
		txtMa_KH.NameControl = lblMa_KH;
		AsTextBox asTextBox5 = txtMa_KH;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_KH).TabIndex = 7;
		txtMa_KH.UseAutoCompleteSource = true;
		Label1.AutoSize = true;
		Label label3 = Label1;
		location = new Point(18, 160);
		((Control)label3).Location = location;
		((Control)Label1).Name = "Label1";
		Label label4 = Label1;
		size = new Size(90, 13);
		((Control)label4).Size = size;
		((Control)Label1).TabIndex = 1043;
		Label1.Text = "DS TK doanh thu";
		txtTk_DT.AutoLookup = true;
		((TextBoxBase)txtTk_DT).BackColor = SystemColors.Info;
		((TextBox)txtTk_DT).CharacterCasing = (CharacterCasing)1;
		AsTextBoxMulti asTextBoxMulti = txtTk_DT;
		location = new Point(110, 157);
		((Control)asTextBoxMulti).Location = location;
		txtTk_DT.LookupCodeName = "tk";
		txtTk_DT.LookupWhereCondition = "tk like '5%'";
		((Control)txtTk_DT).Name = "txtTk_DT";
		txtTk_DT.NameControl = null;
		AsTextBoxMulti asTextBoxMulti2 = txtTk_DT;
		size = new Size(163, 20);
		((Control)asTextBoxMulti2).Size = size;
		((Control)txtTk_DT).TabIndex = 8;
		txtTk_DT.UseAutoCompleteSource = true;
		txtTkDu_DT.AutoLookup = true;
		((TextBoxBase)txtTkDu_DT).BackColor = SystemColors.Info;
		((TextBox)txtTkDu_DT).CharacterCasing = (CharacterCasing)1;
		AsTextBoxMulti asTextBoxMulti3 = txtTkDu_DT;
		location = new Point(110, 183);
		((Control)asTextBoxMulti3).Location = location;
		txtTkDu_DT.LookupCodeName = "tk";
		((Control)txtTkDu_DT).Name = "txtTkDu_DT";
		txtTkDu_DT.NameControl = null;
		AsTextBoxMulti asTextBoxMulti4 = txtTkDu_DT;
		size = new Size(163, 20);
		((Control)asTextBoxMulti4).Size = size;
		((Control)txtTkDu_DT).TabIndex = 10;
		txtTkDu_DT.UseAutoCompleteSource = true;
		Label2.AutoSize = true;
		Label label5 = Label2;
		location = new Point(18, 186);
		((Control)label5).Location = location;
		((Control)Label2).Name = "Label2";
		Label label6 = Label2;
		size = new Size(78, 13);
		((Control)label6).Size = size;
		((Control)Label2).TabIndex = 1045;
		Label2.Text = "DS TK đối ứng";
		((ButtonBase)chkNC_DT).AutoSize = true;
		chkNC_DT.Checked = true;
		chkNC_DT.CheckState = (CheckState)1;
		CheckBox obj19 = chkNC_DT;
		location = new Point(505, 160);
		((Control)obj19).Location = location;
		((Control)chkNC_DT).Name = "chkNC_DT";
		CheckBox obj20 = chkNC_DT;
		size = new Size(95, 17);
		((Control)obj20).Size = size;
		((Control)chkNC_DT).TabIndex = 11;
		((ButtonBase)chkNC_DT).Text = "Lấy PS Nợ/Có";
		((ButtonBase)chkNC_DT).UseVisualStyleBackColor = true;
		((Control)chkNC_DT).Visible = false;
		((ButtonBase)chkNc_CP).AutoSize = true;
		CheckBox obj21 = chkNc_CP;
		location = new Point(505, 208);
		((Control)obj21).Location = location;
		((Control)chkNc_CP).Name = "chkNc_CP";
		CheckBox obj22 = chkNc_CP;
		size = new Size(95, 17);
		((Control)obj22).Size = size;
		((Control)chkNc_CP).TabIndex = 16;
		((ButtonBase)chkNc_CP).Text = "Lấy PS Nợ/Có";
		((ButtonBase)chkNc_CP).UseVisualStyleBackColor = true;
		((Control)chkNc_CP).Visible = false;
		txtTkDu_CP.AutoLookup = true;
		((TextBoxBase)txtTkDu_CP).BackColor = SystemColors.Info;
		((TextBox)txtTkDu_CP).CharacterCasing = (CharacterCasing)1;
		AsTextBoxMulti asTextBoxMulti5 = txtTkDu_CP;
		location = new Point(110, 235);
		((Control)asTextBoxMulti5).Location = location;
		txtTkDu_CP.LookupCodeName = "tk";
		((Control)txtTkDu_CP).Name = "txtTkDu_CP";
		txtTkDu_CP.NameControl = null;
		AsTextBoxMulti asTextBoxMulti6 = txtTkDu_CP;
		size = new Size(163, 20);
		((Control)asTextBoxMulti6).Size = size;
		((Control)txtTkDu_CP).TabIndex = 13;
		txtTkDu_CP.UseAutoCompleteSource = true;
		Label3.AutoSize = true;
		Label label7 = Label3;
		location = new Point(18, 238);
		((Control)label7).Location = location;
		((Control)Label3).Name = "Label3";
		Label label8 = Label3;
		size = new Size(78, 13);
		((Control)label8).Size = size;
		((Control)Label3).TabIndex = 1051;
		Label3.Text = "DS TK đối ứng";
		txtTk_Cp.AutoLookup = true;
		((TextBoxBase)txtTk_Cp).BackColor = SystemColors.Info;
		((TextBox)txtTk_Cp).CharacterCasing = (CharacterCasing)1;
		AsTextBoxMulti asTextBoxMulti7 = txtTk_Cp;
		location = new Point(110, 209);
		((Control)asTextBoxMulti7).Location = location;
		txtTk_Cp.LookupCodeName = "tk";
		txtTk_Cp.LookupWhereCondition = "tk like '6%'";
		((Control)txtTk_Cp).Name = "txtTk_Cp";
		txtTk_Cp.NameControl = null;
		AsTextBoxMulti asTextBoxMulti8 = txtTk_Cp;
		size = new Size(163, 20);
		((Control)asTextBoxMulti8).Size = size;
		((Control)txtTk_Cp).TabIndex = 11;
		txtTk_Cp.UseAutoCompleteSource = true;
		Label5.AutoSize = true;
		Label label9 = Label5;
		location = new Point(18, 212);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(75, 13);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 1049;
		Label5.Text = "DS TK chi phí";
		((ButtonBase)rbDT_No).AutoSize = true;
		RadioButton obj23 = rbDT_No;
		location = new Point(60, 2);
		((Control)obj23).Location = location;
		((Control)rbDT_No).Name = "rbDT_No";
		RadioButton obj24 = rbDT_No;
		size = new Size(39, 17);
		((Control)obj24).Size = size;
		((Control)rbDT_No).TabIndex = 0;
		((ButtonBase)rbDT_No).Text = "Nợ";
		((ButtonBase)rbDT_No).UseVisualStyleBackColor = true;
		((ButtonBase)rbDS_Co).AutoSize = true;
		rbDS_Co.Checked = true;
		RadioButton obj25 = rbDS_Co;
		location = new Point(105, 2);
		((Control)obj25).Location = location;
		((Control)rbDS_Co).Name = "rbDS_Co";
		RadioButton obj26 = rbDS_Co;
		size = new Size(38, 17);
		((Control)obj26).Size = size;
		((Control)rbDS_Co).TabIndex = 1;
		rbDS_Co.TabStop = true;
		((ButtonBase)rbDS_Co).Text = "Có";
		((ButtonBase)rbDS_Co).UseVisualStyleBackColor = true;
		((Control)Panel1).Controls.Add((Control)(object)Label6);
		((Control)Panel1).Controls.Add((Control)(object)rbDT_No);
		((Control)Panel1).Controls.Add((Control)(object)rbDS_Co);
		Panel panel = Panel1;
		location = new Point(280, 157);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(151, 20);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 9;
		Label6.AutoSize = true;
		Label label11 = Label6;
		location = new Point(3, 4);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(51, 13);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 1052;
		Label6.Text = "Phát sinh";
		((Control)Panel2).Controls.Add((Control)(object)Label7);
		((Control)Panel2).Controls.Add((Control)(object)rbCP_No);
		((Control)Panel2).Controls.Add((Control)(object)rbCP_CO);
		Panel panel3 = Panel2;
		location = new Point(280, 209);
		((Control)panel3).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel4 = Panel2;
		size = new Size(151, 20);
		((Control)panel4).Size = size;
		((Control)Panel2).TabIndex = 12;
		Label7.AutoSize = true;
		Label label13 = Label7;
		location = new Point(3, 4);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(51, 13);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 1053;
		Label7.Text = "Phát sinh";
		((ButtonBase)rbCP_No).AutoSize = true;
		rbCP_No.Checked = true;
		RadioButton obj27 = rbCP_No;
		location = new Point(60, 2);
		((Control)obj27).Location = location;
		((Control)rbCP_No).Name = "rbCP_No";
		RadioButton obj28 = rbCP_No;
		size = new Size(39, 17);
		((Control)obj28).Size = size;
		((Control)rbCP_No).TabIndex = 0;
		rbCP_No.TabStop = true;
		((ButtonBase)rbCP_No).Text = "Nợ";
		((ButtonBase)rbCP_No).UseVisualStyleBackColor = true;
		((ButtonBase)rbCP_CO).AutoSize = true;
		RadioButton obj29 = rbCP_CO;
		location = new Point(105, 2);
		((Control)obj29).Location = location;
		((Control)rbCP_CO).Name = "rbCP_CO";
		RadioButton obj30 = rbCP_CO;
		size = new Size(38, 17);
		((Control)obj30).Size = size;
		((Control)rbCP_CO).TabIndex = 1;
		((ButtonBase)rbCP_CO).Text = "Có";
		((ButtonBase)rbCP_CO).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(685, 485);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmSORptLaiLo";
		((Form)this).Text = "SORptLaiLo";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public frmSORptLaiLo(string menuid)
		: base(menuid)
	{
		((Form)this).Load += frmSORptLaiLo_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_HD).Text);
		arrayList.Add(((TextBox)txtMa_KH).Text);
		arrayList.Add(((TextBox)txtTk_DT).Text);
		arrayList.Add(((TextBox)txtTkDu_DT).Text);
		arrayList.Add(chkNC_DT.Checked);
		arrayList.Add(((TextBox)txtTk_Cp).Text);
		arrayList.Add(((TextBox)txtTkDu_CP).Text);
		arrayList.Add(chkNc_CP.Checked);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (Operators.CompareString(((TextBox)txtMa_HD).Text, "", false) != 0)
		{
			text = text + lblMa_TD.Text + " :" + ((TextBox)txtMa_HD).Text + ";";
		}
		if (Operators.CompareString(((TextBox)txtMa_KH).Text, "", false) != 0)
		{
			text = text + lblMa_KH.Text + " :" + ((TextBox)txtMa_KH).Text + ";";
		}
		return text;
	}

	protected override bool ValidData()
	{
		return base.ValidData();
	}

	private void frmSORptLaiLo_Load(object sender, EventArgs e)
	{
		((TextBox)txtTk_DT).Text = MyMenuInfo.par3;
		((TextBox)txtTk_Cp).Text = MyMenuInfo.par4;
		((Control)cboKyBc).Select();
	}

	private void rbDT_No_CheckedChanged(object sender, EventArgs e)
	{
		chkNC_DT.Checked = !rbDT_No.Checked;
	}

	private void tbCP_No_CheckedChanged(object sender, EventArgs e)
	{
		chkNc_CP.Checked = !rbCP_No.Checked;
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		DataRowView dataRowView;
		ArrayList result;
		try
		{
			dataRowView = new DataView((DataTable)base.dgvBC.DataSource)[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index];
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			base.CancelDrilldown = true;
			result = null;
			ProjectData.ClearProjectError();
			goto IL_01bf;
		}
		if ((int)keycode != 116 || (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_hd"]), isNum: false), (object)"", false) ? true : false))
		{
			base.CancelDrilldown = true;
			result = null;
		}
		else
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ma_hd"]));
			arrayList.Add(((TextBox)txtMa_KH).Text);
			arrayList.Add(((TextBox)txtTk_DT).Text);
			arrayList.Add(((TextBox)txtTkDu_DT).Text);
			arrayList.Add(chkNC_DT.Checked);
			arrayList.Add(((TextBox)txtTk_Cp).Text);
			arrayList.Add(((TextBox)txtTkDu_CP).Text);
			arrayList.Add(chkNc_CP.Checked);
			if (Information.IsDBNull((object)arrayList))
			{
				base.CancelDrilldown = true;
				result = null;
			}
			else
			{
				filterCondition4title = dataRowView["ma_hd"].ToString() + ": " + dataRowView["ten_hd"].ToString();
				result = arrayList;
			}
		}
		goto IL_01bf;
		IL_01bf:
		return result;
	}
}
