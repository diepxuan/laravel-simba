using System;
using System.Collections;
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
public class frmRptCommon : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("palFilter")]
	private FlowLayoutPanel _palFilter;

	[AccessedThroughProperty("palFilterMa")]
	private Panel _palFilterMa;

	private ArrayList f_arrParRequired;

	private ArrayList f_arrParControls;

	private ToolTip oToolTip;

	internal virtual FlowLayoutPanel palFilter
	{
		[DebuggerNonUserCode]
		get
		{
			return _palFilter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palFilter = value;
		}
	}

	internal virtual Panel palFilterMa
	{
		[DebuggerNonUserCode]
		get
		{
			return _palFilterMa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palFilterMa = value;
		}
	}

	public frmRptCommon(string MenuID)
		: base(MenuID)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmSORptBK01_KeyDown);
		f_arrParRequired = new ArrayList();
		f_arrParControls = new ArrayList();
		oToolTip = new ToolTip();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		palFilter = new FlowLayoutPanel();
		palFilterMa = new Panel();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)tabGrid).SuspendLayout();
		((Control)palFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(886, 526);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)palFilter);
		TabPage obj = tabFilter;
		size = new Size(878, 497);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)palFilter, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
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
		Label obj2 = lbl2;
		Point location = new Point(277, 81);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 28;
		Button obj3 = cmdExcel;
		location = new Point(804, 501);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 24;
		myHelpProvider.SetHelpKeyword((Control)(object)txtNgay2, "ttt");
		myHelpProvider.SetHelpString((Control)(object)txtNgay2, "Test");
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(296, 77);
		((Control)asMaskedTextBox).Location = location;
		myHelpProvider.SetShowHelp((Control)(object)txtNgay2, true);
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(723, 501);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 23;
		((Control)cmdModifyReport).TabIndex = 29;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(206, 77);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj5 = cboKyBc;
		location = new Point(110, 77);
		((Control)obj5).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj6 = lblKyBc;
		location = new Point(24, 81);
		((Control)obj6).Location = location;
		((Control)lblKyBc).TabIndex = 66;
		myHelpProvider.SetHelpKeyword((Control)(object)cboMau_bc, "");
		myHelpProvider.SetHelpString((Control)(object)cboMau_bc, "");
		ComboBox obj7 = cboMau_bc;
		location = new Point(110, 24);
		((Control)obj7).Location = location;
		myHelpProvider.SetShowHelp((Control)(object)cboMau_bc, false);
		((Control)cboMau_bc).TabIndex = 28;
		((Control)lblMau_bc).TabIndex = 68;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 413);
		((Control)asTextBox).Location = location;
		AsTextBox asTextBox2 = txtMa_Nt;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(3, 4, 3, 3);
		((Control)asTextBox2).Margin = margin;
		((Control)txtMa_Nt).TabIndex = 9;
		Label obj8 = lblMauBC;
		location = new Point(155, 413);
		((Control)obj8).Location = location;
		Label obj9 = lblMauBC;
		((Padding)(ref margin))._002Ector(3, 4, 3, 0);
		((Control)obj9).Margin = margin;
		((Control)lblMauBC).TabIndex = 10;
		RadioButton obj10 = optVND;
		location = new Point(230, 412);
		((Control)obj10).Location = location;
		RadioButton obj11 = optVND;
		((Padding)(ref margin))._002Ector(3, 4, 3, 3);
		((Control)obj11).Margin = margin;
		((Control)optVND).TabIndex = 11;
		optVND.TabStop = false;
		RadioButton obj12 = optNt;
		location = new Point(296, 413);
		((Control)obj12).Location = location;
		RadioButton obj13 = optNt;
		((Padding)(ref margin))._002Ector(3, 4, 3, 3);
		((Control)obj13).Margin = margin;
		RadioButton obj14 = optNt;
		size = new Size(174, 22);
		((Control)obj14).Size = size;
		((Control)optNt).TabIndex = 12;
		Label obj15 = lblMa_nt;
		location = new Point(24, 417);
		((Control)obj15).Location = location;
		Label obj16 = lblMa_nt;
		((Padding)(ref margin))._002Ector(0, 4, 0, 0);
		((Control)obj16).Margin = margin;
		Label obj17 = lblMa_nt;
		size = new Size(83, 16);
		((Control)obj17).Size = size;
		((Control)lblMa_nt).TabIndex = 8;
		myHelpProvider.SetHelpKeyword((Control)(object)cmdOk, "");
		myHelpProvider.SetHelpString((Control)(object)cmdOk, "");
		Button obj18 = cmdOk;
		location = new Point(23, 436);
		((Control)obj18).Location = location;
		Button obj19 = cmdOk;
		((Padding)(ref margin))._002Ector(3, 4, 3, 3);
		((Control)obj19).Margin = margin;
		myHelpProvider.SetShowHelp((Control)(object)cmdOk, false);
		((Control)cmdOk).TabIndex = 13;
		Label obj20 = lblTieu_de;
		location = new Point(24, 55);
		((Control)obj20).Location = location;
		((Control)lblTieu_de).TabIndex = 67;
		TextBox obj21 = txtTieu_De;
		location = new Point(110, 51);
		((Control)obj21).Location = location;
		((Control)txtTieu_De).TabIndex = 30;
		TabPage obj22 = tabGrid;
		size = new Size(878, 497);
		((Control)obj22).Size = size;
		((Control)palFilter).Controls.Add((Control)(object)palFilterMa);
		FlowLayoutPanel obj23 = palFilter;
		location = new Point(23, 104);
		((Control)obj23).Location = location;
		FlowLayoutPanel obj24 = palFilter;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj24).Margin = margin;
		((Control)palFilter).Name = "palFilter";
		FlowLayoutPanel obj25 = palFilter;
		size = new Size(447, 305);
		((Control)obj25).Size = size;
		((Control)palFilter).TabIndex = 1;
		palFilterMa.AutoSize = true;
		Panel obj26 = palFilterMa;
		location = new Point(0, 0);
		((Control)obj26).Location = location;
		Panel obj27 = palFilterMa;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj27).Margin = margin;
		((Control)palFilterMa).Name = "palFilterMa";
		Panel obj28 = palFilterMa;
		size = new Size(0, 0);
		((Control)obj28).Size = size;
		((Control)palFilterMa).TabIndex = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).AutoScroll = true;
		size = new Size(886, 551);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmRptCommon";
		((Form)this).Text = "";
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)tabGrid).ResumeLayout(false);
		((Control)palFilter).ResumeLayout(false);
		((Control)palFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		base.InitOtherComponents();
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(MyMenuInfo.moduleid);
		arrayList.Add("0");
		int x = 0;
		int num = 3;
		int num2 = 87;
		int num3 = 0;
		int x2 = 182;
		int num4 = 3;
		string[] array = MyMenuInfo.par1.Split(new char[1] { ',' });
		string text = "";
		int num5 = 4;
		checked
		{
			int num6 = array.Length - 1;
			for (int i = 0; i <= num6; i++)
			{
				Control val = new Control();
				Label val2 = new Label();
				Label val3 = new Label();
				bool flag = false;
				string[] array2 = array[i].Split(new char[1] { ':' });
				text = array2[0].Trim();
				val.Name = "txt" + text;
				((Control)val3).Name = "lbl" + Strings.Right(text, Strings.Len(text) - 2);
				Point location = new Point(x, i * 25 + num);
				((Control)val2).Location = location;
				val2.AutoSize = true;
				int num7 = array2.Length - 1;
				for (int j = 1; j <= num7; j++)
				{
					if (array2[j].StartsWith("L="))
					{
						((Control)val2).Name = "lbl" + text;
						val2.Text = Strings.Right(array2[j], Strings.Len(array2[j]) - 2);
					}
					if (array2[j].StartsWith("R"))
					{
						f_arrParRequired.Add(val);
					}
					if (!array2[j].StartsWith("T="))
					{
						continue;
					}
					string text2 = Strings.Right(array2[j], 1);
					string text3 = text2;
					if (Operators.CompareString(text3, "C", false) == 0)
					{
						val = (Control)(object)new AsTextBox();
						((AsTextBox)(object)val).AutoLookup = true;
						((TextBox)(AsTextBox)(object)val).CharacterCasing = (CharacterCasing)1;
						((AsTextBox)(object)val).LookupCodeName = text;
						((AsTextBox)(object)val).LookupWhereCondition = "";
						((AsTextBox)(object)val).NameControl = val3;
						((AsTextBox)(object)val).UseAutoCompleteSource = true;
						Control obj = val;
						location = new Point(num2, i * 25 + num3);
						obj.Location = location;
						val.BackColor = SystemColors.Info;
						val.Name = "txt" + text;
						Control obj2 = val;
						Size size = new Size(90, 20);
						obj2.Size = size;
						val.Tag = text;
						val.TabIndex = num5;
						num5++;
						flag = true;
						f_arrParControls.Add(val);
					}
					else if (Operators.CompareString(text3, "T", false) == 0)
					{
						val = (Control)new TextBox();
						val.TabIndex = num5;
						num5++;
						Control obj3 = val;
						location = new Point(num2, i * 25 + num3);
						obj3.Location = location;
						val.BackColor = SystemColors.Window;
						val.Name = "txt" + text;
						val.Tag = text;
						if (Strings.Left(text, 5).ToUpper().Equals("SO_CT"))
						{
							val2.Text = "Chứng từ số";
							Control obj4 = val;
							Size size = new Size(90, 20);
							obj4.Size = size;
							val.Name = "txt" + text + "1";
							Label val4 = new Label();
							location = new Point(num2 + 100, i * 25 + num3);
							((Control)val4).Location = location;
							((Control)val4).Name = "lblSo_ct2";
							val4.Text = "Đến số";
							val4.AutoSize = true;
							TextBox val5 = new TextBox();
							location = new Point(num2 + 170, i * 25 + num3);
							((Control)val5).Location = location;
							((TextBoxBase)val5).BackColor = SystemColors.Window;
							size = new Size(90, 20);
							((Control)val5).Size = size;
							((Control)val5).Name = "txt" + text + "2";
							((Control)val5).Tag = "so_ct2";
							((Control)val5).TabIndex = num5;
							num5++;
							((Control)tabFilter).Controls.Add((Control)(object)val4);
							((Control)tabFilter).Controls.Add((Control)(object)val5);
							f_arrParControls.Add(val);
							f_arrParControls.Add(val5);
						}
						else
						{
							Control obj5 = val;
							Size size = new Size(330, 20);
							obj5.Size = size;
							f_arrParControls.Add(val);
						}
					}
				}
				((Control)palFilterMa).Controls.Add((Control)(object)val2);
				((Control)palFilterMa).Controls.Add(val);
				if (flag)
				{
					location = new Point(x2, i * 25 + num4);
					((Control)val3).Location = location;
					val3.AutoSize = true;
					((Control)palFilterMa).Controls.Add((Control)(object)val3);
				}
			}
			((Control)palFilter).Controls.Add((Control)(object)lblMa_nt);
			((Control)palFilter).Controls.Add((Control)(object)txtMa_Nt);
			((Control)palFilter).Controls.Add((Control)(object)lblMauBC);
			((Control)palFilter).Controls.Add((Control)(object)optVND);
			((Control)palFilter).Controls.Add((Control)(object)optNt);
			((Control)palFilter).Controls.Add((Control)(object)cmdOk);
			((Control)txtMa_Nt).TabIndex = num5;
			((Control)cmdOk).TabIndex = num5 + 2;
			((Control)cboMau_bc).TabIndex = num5 + 3;
			((Control)txtTieu_De).TabIndex = num5 + 4;
		}
	}

	protected override bool LoadData()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		foreach (TextBox f_arrParControl in f_arrParControls)
		{
			TextBox val = f_arrParControl;
			arrayList.Add(val.Text);
		}
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	protected override bool ValidData()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		foreach (TextBox item in f_arrParRequired)
		{
			TextBox txt = item;
			if (!ChkEmtyTextBox(txt))
			{
				return false;
			}
		}
		return base.ValidData();
	}

	private string GetFilterTitle()
	{
		return string.Empty;
	}

	private void dgvBCPh_RowEnter(object sender, DataGridViewCellEventArgs e)
	{
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (((object)(DataTable)((DataGridView)dgvBC).DataSource != DBNull.Value) & ((DataTable)((DataGridView)dgvBC).DataSource != null))
			{
				((DataTable)((DataGridView)dgvBC).DataSource).DefaultView.RowFilter = "stt_rec='" + ((DataTable)((DataGridView)dgvBC).DataSource).DefaultView[e.RowIndex]["stt_rec"].ToString() + "'";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void setDataSourceToCmb(ComboBox combobox, ArrayList ar, string member, string value)
	{
		combobox.DataSource = ar;
		((ListControl)combobox).DisplayMember = member;
		((ListControl)combobox).ValueMember = value;
	}

	private void frmSORptBK01_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 13)
		{
			SendKeys.Send("{TAB}");
		}
	}
}
