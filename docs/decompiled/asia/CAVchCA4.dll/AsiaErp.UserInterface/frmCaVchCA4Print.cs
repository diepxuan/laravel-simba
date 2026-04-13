using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCaVchCA4Print : frmVoucherPrint
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("txtTinh_tp_nt")]
	private TextBox _txtTinh_tp_nt;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("txtTen_Nh_nt")]
	private TextBox _txtTen_Nh_nt;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("txtTen_dv_nt")]
	private TextBox _txtTen_dv_nt;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtTinh_tp_tt")]
	private TextBox _txtTinh_tp_tt;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtTen_Nh_tt")]
	private TextBox _txtTen_Nh_tt;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtSo_tk_tt")]
	private TextBox _txtSo_tk_tt;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtTen_Dv_tt")]
	private TextBox _txtTen_Dv_tt;

	[AccessedThroughProperty("txtSo_tk_nt")]
	private AsTextBox _txtSo_tk_nt;

	internal string sMa_kh;

	internal string sTen_Kh;

	internal string sTk;

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

	internal virtual TextBox txtTinh_tp_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTinh_tp_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTinh_tp_nt = value;
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

	internal virtual TextBox txtTen_Nh_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Nh_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Nh_nt = value;
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

	internal virtual TextBox txtTen_dv_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_dv_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_dv_nt = value;
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

	internal virtual TextBox txtTinh_tp_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTinh_tp_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTinh_tp_tt = value;
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

	internal virtual TextBox txtTen_Nh_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Nh_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Nh_tt = value;
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

	internal virtual TextBox txtSo_tk_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_tk_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_tk_tt = value;
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

	internal virtual TextBox txtTen_Dv_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Dv_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Dv_tt = value;
		}
	}

	internal virtual AsTextBox txtSo_tk_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_tk_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtSo_tk_nt_AfterCodeValidating;
			if (_txtSo_tk_nt != null)
			{
				_txtSo_tk_nt.AfterCodeValidating -= obj;
			}
			_txtSo_tk_nt = value;
			if (_txtSo_tk_nt != null)
			{
				_txtSo_tk_nt.AfterCodeValidating += obj;
			}
		}
	}

	public frmCaVchCA4Print()
	{
		__ENCAddToList(this);
		sMa_kh = "";
		sTen_Kh = "";
		sTk = "";
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
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
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
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected O, but got Unknown
		//IL_0bef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf9: Expected O, but got Unknown
		Label5 = new Label();
		txtTinh_tp_nt = new TextBox();
		Label6 = new Label();
		txtTen_Nh_nt = new TextBox();
		Label7 = new Label();
		Label8 = new Label();
		txtTen_dv_nt = new TextBox();
		Label4 = new Label();
		txtTinh_tp_tt = new TextBox();
		Label3 = new Label();
		txtTen_Nh_tt = new TextBox();
		Label2 = new Label();
		txtSo_tk_tt = new TextBox();
		Label1 = new Label();
		txtTen_Dv_tt = new TextBox();
		txtSo_tk_nt = new AsTextBox();
		((Control)gbPrint).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)gbPrint).Controls.Add((Control)(object)Label8);
		((Control)gbPrint).Controls.Add((Control)(object)txtTen_dv_nt);
		((Control)gbPrint).Controls.Add((Control)(object)Label4);
		((Control)gbPrint).Controls.Add((Control)(object)txtTinh_tp_tt);
		((Control)gbPrint).Controls.Add((Control)(object)Label3);
		((Control)gbPrint).Controls.Add((Control)(object)txtSo_tk_nt);
		((Control)gbPrint).Controls.Add((Control)(object)txtTen_Nh_tt);
		((Control)gbPrint).Controls.Add((Control)(object)Label2);
		((Control)gbPrint).Controls.Add((Control)(object)Label7);
		((Control)gbPrint).Controls.Add((Control)(object)txtSo_tk_tt);
		((Control)gbPrint).Controls.Add((Control)(object)Label5);
		((Control)gbPrint).Controls.Add((Control)(object)txtTinh_tp_nt);
		((Control)gbPrint).Controls.Add((Control)(object)Label6);
		((Control)gbPrint).Controls.Add((Control)(object)txtTen_Nh_nt);
		((Control)gbPrint).Controls.Add((Control)(object)Label1);
		((Control)gbPrint).Controls.Add((Control)(object)txtTen_Dv_tt);
		GroupBox obj = gbPrint;
		Size size = new Size(558, 328);
		((Control)obj).Size = size;
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)txtTen_Dv_tt, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)txtTen_Nh_nt, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)txtTinh_tp_nt, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)txtSo_tk_tt, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)txtTen_Nh_tt, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)txtSo_tk_nt, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)txtTinh_tp_tt, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)lblSo_lien, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)txtSo_lien, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)txtTen_dv_nt, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)lblSo_Ct_kem, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)txtSo_Ct_Kem, 0);
		ComboBox obj2 = cboMau_bc;
		Point location = new Point(126, 20);
		((Control)obj2).Location = location;
		ComboBox obj3 = cboMau_bc;
		size = new Size(327, 21);
		((Control)obj3).Size = size;
		Label obj4 = lblMau_bc;
		location = new Point(12, 23);
		((Control)obj4).Location = location;
		Label obj5 = lblTieu_de;
		location = new Point(12, 50);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).Anchor = (AnchorStyles)5;
		Button obj6 = cmdModifyReport;
		location = new Point(459, 18);
		((Control)obj6).Location = location;
		Label obj7 = lblSo_lien;
		location = new Point(12, 304);
		((Control)obj7).Location = location;
		((Control)lblSo_Ct_kem).Enabled = false;
		Label obj8 = lblSo_Ct_kem;
		location = new Point(574, 376);
		((Control)obj8).Location = location;
		((Control)lblSo_Ct_kem).Visible = false;
		Button obj9 = cmdCancel;
		location = new Point(152, 338);
		((Control)obj9).Location = location;
		Button obj10 = cmPreview;
		location = new Point(82, 338);
		((Control)obj10).Location = location;
		Button obj11 = cmdPrint;
		location = new Point(12, 338);
		((Control)obj11).Location = location;
		TextBox obj12 = txtTieu_De;
		location = new Point(126, 47);
		((Control)obj12).Location = location;
		((Control)txtSo_Ct_Kem).Enabled = false;
		TextBox obj13 = txtSo_Ct_Kem;
		location = new Point(693, 372);
		((Control)obj13).Location = location;
		((Control)txtSo_Ct_Kem).Visible = false;
		AsTextNumeric asTextNumeric = txtSo_lien;
		location = new Point(126, 301);
		((Control)asTextNumeric).Location = location;
		((Control)txtSo_lien).TabIndex = 10;
		Label5.AutoSize = true;
		Label label = Label5;
		location = new Point(22, 268);
		((Control)label).Location = location;
		((Control)Label5).Name = "Label5";
		Label label2 = Label5;
		size = new Size(82, 13);
		((Control)label2).Size = size;
		((Control)Label5).TabIndex = 165;
		Label5.Text = "Tỉnh, thành phố";
		TextBox obj14 = txtTinh_tp_nt;
		location = new Point(160, 264);
		((Control)obj14).Location = location;
		((Control)txtTinh_tp_nt).Name = "txtTinh_tp_nt";
		TextBox obj15 = txtTinh_tp_nt;
		size = new Size(205, 20);
		((Control)obj15).Size = size;
		((Control)txtTinh_tp_nt).TabIndex = 9;
		Label6.AutoSize = true;
		Label label3 = Label6;
		location = new Point(22, 242);
		((Control)label3).Location = location;
		((Control)Label6).Name = "Label6";
		Label label4 = Label6;
		size = new Size(76, 13);
		((Control)label4).Size = size;
		((Control)Label6).TabIndex = 164;
		Label6.Text = "Tại ngân hàng";
		TextBox obj16 = txtTen_Nh_nt;
		location = new Point(160, 238);
		((Control)obj16).Location = location;
		((Control)txtTen_Nh_nt).Name = "txtTen_Nh_nt";
		TextBox obj17 = txtTen_Nh_nt;
		size = new Size(374, 20);
		((Control)obj17).Size = size;
		((Control)txtTen_Nh_nt).TabIndex = 8;
		Label7.AutoSize = true;
		Label label5 = Label7;
		location = new Point(22, 216);
		((Control)label5).Location = location;
		((Control)Label7).Name = "Label7";
		Label label6 = Label7;
		size = new Size(67, 13);
		((Control)label6).Size = size;
		((Control)Label7).TabIndex = 163;
		Label7.Text = "Số tài khoản";
		Label8.AutoSize = true;
		((Control)Label8).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label7 = Label8;
		location = new Point(12, 190);
		((Control)label7).Location = location;
		((Control)Label8).Name = "Label8";
		Label label8 = Label8;
		size = new Size(101, 13);
		((Control)label8).Size = size;
		((Control)Label8).TabIndex = 162;
		Label8.Text = "Đơn vị nhận tiền";
		TextBox obj18 = txtTen_dv_nt;
		location = new Point(126, 187);
		((Control)obj18).Location = location;
		((Control)txtTen_dv_nt).Name = "txtTen_dv_nt";
		TextBox obj19 = txtTen_dv_nt;
		size = new Size(408, 20);
		((Control)obj19).Size = size;
		((Control)txtTen_dv_nt).TabIndex = 6;
		Label4.AutoSize = true;
		Label label9 = Label4;
		location = new Point(22, 156);
		((Control)label9).Location = location;
		((Control)Label4).Name = "Label4";
		Label label10 = Label4;
		size = new Size(82, 13);
		((Control)label10).Size = size;
		((Control)Label4).TabIndex = 161;
		Label4.Text = "Tỉnh, thành phố";
		TextBox obj20 = txtTinh_tp_tt;
		location = new Point(160, 152);
		((Control)obj20).Location = location;
		((Control)txtTinh_tp_tt).Name = "txtTinh_tp_tt";
		TextBox obj21 = txtTinh_tp_tt;
		size = new Size(205, 20);
		((Control)obj21).Size = size;
		((Control)txtTinh_tp_tt).TabIndex = 5;
		Label3.AutoSize = true;
		Label label11 = Label3;
		location = new Point(22, 130);
		((Control)label11).Location = location;
		((Control)Label3).Name = "Label3";
		Label label12 = Label3;
		size = new Size(76, 13);
		((Control)label12).Size = size;
		((Control)Label3).TabIndex = 160;
		Label3.Text = "Tại ngân hàng";
		TextBox obj22 = txtTen_Nh_tt;
		location = new Point(160, 126);
		((Control)obj22).Location = location;
		((Control)txtTen_Nh_tt).Name = "txtTen_Nh_tt";
		TextBox obj23 = txtTen_Nh_tt;
		size = new Size(374, 20);
		((Control)obj23).Size = size;
		((Control)txtTen_Nh_tt).TabIndex = 4;
		Label2.AutoSize = true;
		Label label13 = Label2;
		location = new Point(22, 104);
		((Control)label13).Location = location;
		((Control)Label2).Name = "Label2";
		Label label14 = Label2;
		size = new Size(67, 13);
		((Control)label14).Size = size;
		((Control)Label2).TabIndex = 159;
		Label2.Text = "Số tài khoản";
		TextBox obj24 = txtSo_tk_tt;
		location = new Point(160, 100);
		((Control)obj24).Location = location;
		((Control)txtSo_tk_tt).Name = "txtSo_tk_tt";
		TextBox obj25 = txtSo_tk_tt;
		size = new Size(205, 20);
		((Control)obj25).Size = size;
		((Control)txtSo_tk_tt).TabIndex = 3;
		Label1.AutoSize = true;
		((Control)Label1).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label15 = Label1;
		location = new Point(12, 78);
		((Control)label15).Location = location;
		((Control)Label1).Name = "Label1";
		Label label16 = Label1;
		size = new Size(88, 13);
		((Control)label16).Size = size;
		((Control)Label1).TabIndex = 158;
		Label1.Text = "Đơn vị trả tiền";
		TextBox obj26 = txtTen_Dv_tt;
		location = new Point(126, 75);
		((Control)obj26).Location = location;
		((Control)txtTen_Dv_tt).Name = "txtTen_Dv_tt";
		TextBox obj27 = txtTen_Dv_tt;
		size = new Size(408, 20);
		((Control)obj27).Size = size;
		((Control)txtTen_Dv_tt).TabIndex = 2;
		txtSo_tk_nt.AutoLookup = true;
		txtSo_tk_nt.AutoValid = false;
		((TextBoxBase)txtSo_tk_nt).BackColor = SystemColors.Window;
		((TextBox)txtSo_tk_nt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtSo_tk_nt;
		location = new Point(160, 212);
		((Control)asTextBox).Location = location;
		txtSo_tk_nt.LookupCodeName = "SO_TK";
		((Control)txtSo_tk_nt).Name = "txtSo_tk_nt";
		txtSo_tk_nt.NameControl = null;
		AsTextBox asTextBox2 = txtSo_tk_nt;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtSo_tk_nt).TabIndex = 7;
		txtSo_tk_nt.UseAutoCompleteSource = true;
		txtSo_tk_nt.ValidReturnFieldList = "so_tk,ma_ngh,ten_ngh,tinh_tp";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(582, 373);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCaVchCA4Print";
		((Control)gbPrint).ResumeLayout(false);
		((Control)gbPrint).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitOtherComponent()
	{
		base.InitOtherComponent();
		txtTen_Dv_tt.Text = CompanyInformations.CompanyName;
		txtSo_tk_tt.Text = CompanyInformations.BankAccount;
		txtTen_Nh_tt.Text = CompanyInformations.BankName;
		txtTinh_tp_tt.Text = CompanyInformations.BankLocation;
		DataTable dataTable = new DataTable();
		dataTable = Commons.GetDataTable("asGLGetDMTK", CompanyInformations.CompanyID, sTk, null, null, null);
		if (dataTable.Rows.Count != 0)
		{
			DataRow dataRow = dataTable.Rows[0];
			txtSo_tk_tt.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["so_tk"]), isNum: false));
			txtTen_Nh_tt.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["ten_ngh"]), isNum: false));
			txtTinh_tp_tt.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["tinh_tp"]), isNum: false));
			if (!Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["ma_ngh"]), isNum: false), (object)"", false))
			{
				((ListControl)cboMau_bc).SelectedValue = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["ma_ngh"]), isNum: false));
			}
			txtTen_dv_nt.Text = sTen_Kh;
			txtSo_tk_nt.LookupWhereCondition = "ma_kh = '" + sMa_kh + "'";
		}
		GetCustomerInfo4Print();
	}

	protected override void SetExtensionFormulaField()
	{
		base.SetExtensionFormulaField();
		base.MyFomularFields.Add("ten_dv_tt", txtTen_Dv_tt.Text.Trim());
		base.MyFomularFields.Add("so_tk_tt", txtSo_tk_tt.Text.Trim());
		base.MyFomularFields.Add("ten_nh_tt", txtTen_Nh_tt.Text.Trim());
		base.MyFomularFields.Add("tinh_tp_tt", txtTinh_tp_tt.Text.Trim());
		base.MyFomularFields.Add("ten_dv_nt", txtTen_dv_nt.Text.Trim());
		base.MyFomularFields.Add("so_tk_nt", ((TextBox)txtSo_tk_nt).Text.Trim());
		base.MyFomularFields.Add("ten_nh_nt", txtTen_Nh_nt.Text.Trim());
		base.MyFomularFields.Add("tinh_tp_nt", txtTinh_tp_nt.Text.Trim());
	}

	private void GetCustomerInfo4Print()
	{
		DataRow pDrw = null;
		if (Commons.ValidMa(ref pDrw, "MA_KH", sMa_kh, "", "so_tk_nh,ten_nh,tinh_tp_nh"))
		{
			((TextBox)txtSo_tk_nt).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(pDrw["so_tk_nh"]), isNum: false));
			txtTen_Nh_nt.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(pDrw["ten_nh"]), isNum: false));
			txtTinh_tp_nt.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(pDrw["tinh_tp_nh"]), isNum: false));
			txtTen_dv_nt.Text = sTen_Kh;
			DataTable dataTable = new DataTable();
			dataTable = Commons.GetDataTable("asGetarDMKH_NH", CompanyInformations.CompanyID, sMa_kh, "", "0", null);
			if (dataTable.Rows.Count != 0)
			{
				DataRow dataRow = dataTable.Rows[0];
				((TextBox)txtSo_tk_nt).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["so_tk"]), isNum: false));
				txtTen_Nh_nt.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["ten_ngh"]), isNum: false));
				txtTinh_tp_nt.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["tinh_tp"]), isNum: false));
			}
		}
	}

	private void txtSo_tk_nt_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		txtTinh_tp_nt.Text = Conversions.ToString(e.ValidatedRow["tinh_tp"]);
		txtTen_Nh_nt.Text = Conversions.ToString(e.ValidatedRow["ten_ngh"]);
	}
}
