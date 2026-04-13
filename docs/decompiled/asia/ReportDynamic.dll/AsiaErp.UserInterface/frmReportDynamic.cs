using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmReportDynamic : frmReport
{
	private IContainer components;

	private const decimal W_TEXT = 330m;

	private const decimal W_LOOK = 90m;

	private const decimal W_DROP = 90m;

	private const decimal W_CHECK = 90m;

	private const decimal W_RADIO = 396m;

	private const int H_ALING_TEXT = 10;

	private const int H_ALING_GROUP = 25;

	private List<Control> f_arrParRequired;

	private List<Control> f_arrParControls;

	private List<Label> f_arrLabelControls;

	public frmReportDynamic(string MenuID)
		: base(MenuID)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmReportDynamic_KeyDown);
		f_arrParRequired = new List<Control>();
		f_arrParControls = new List<Control>();
		f_arrLabelControls = new List<Label>();
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
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(886, 526);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		TabPage obj = tabFilter;
		size = new Size(878, 497);
		((Control)obj).Size = size;
		Label obj2 = lbl2;
		Point location = new Point(277, 81);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 28;
		Button obj3 = cmdExcel;
		location = new Point(804, 226);
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
		location = new Point(723, 226);
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
		location = new Point(804, 439);
		((Control)asTextBox).Location = location;
		AsTextBox asTextBox2 = txtMa_Nt;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(3, 4, 3, 3);
		((Control)asTextBox2).Margin = margin;
		((Control)txtMa_Nt).TabIndex = 9;
		((Control)txtMa_Nt).Visible = false;
		Label obj8 = lblMauBC;
		location = new Point(24, 108);
		((Control)obj8).Location = location;
		Label obj9 = lblMauBC;
		((Padding)(ref margin))._002Ector(3, 4, 3, 0);
		((Control)obj9).Margin = margin;
		((Control)lblMauBC).TabIndex = 10;
		RadioButton obj10 = optVND;
		location = new Point(99, 107);
		((Control)obj10).Location = location;
		RadioButton obj11 = optVND;
		((Padding)(ref margin))._002Ector(3, 4, 3, 3);
		((Control)obj11).Margin = margin;
		((Control)optVND).TabIndex = 11;
		optVND.TabStop = false;
		RadioButton obj12 = optNt;
		location = new Point(165, 108);
		((Control)obj12).Location = location;
		RadioButton obj13 = optNt;
		((Padding)(ref margin))._002Ector(3, 4, 3, 3);
		((Control)obj13).Margin = margin;
		RadioButton obj14 = optNt;
		size = new Size(82, 20);
		((Control)obj14).Size = size;
		((Control)optNt).TabIndex = 12;
		Label obj15 = lblMa_nt;
		location = new Point(718, 443);
		((Control)obj15).Location = location;
		Label obj16 = lblMa_nt;
		((Padding)(ref margin))._002Ector(0, 4, 0, 0);
		((Control)obj16).Margin = margin;
		Label obj17 = lblMa_nt;
		size = new Size(83, 16);
		((Control)obj17).Size = size;
		((Control)lblMa_nt).TabIndex = 8;
		((Control)lblMa_nt).Visible = false;
		myHelpProvider.SetHelpKeyword((Control)(object)cmdOk, "");
		myHelpProvider.SetHelpString((Control)(object)cmdOk, "");
		Button obj18 = cmdOk;
		location = new Point(25, 131);
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
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).AutoScroll = true;
		size = new Size(886, 551);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmReportDynamic";
		((Form)this).Text = "";
		((Form)this).WindowState = (FormWindowState)2;
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
		DrawingFilterControl();
	}

	protected void DrawingFilterControl()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected O, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected O, but got Unknown
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Expected O, but got Unknown
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected O, but got Unknown
		//IL_0a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected O, but got Unknown
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected O, but got Unknown
		int x = 24;
		int num = 107;
		int num2 = 110;
		int num3 = 104;
		int x2 = 202;
		int num4 = 107;
		string lookupList = AsiaErp.Framework.Environment.GetSIConfiguration().LookupList;
		ReportDynamicDAO reportDynamicDAO = (ReportDynamicDAO)DAOFactory.CreateDAOInstance("ReportDynamicDAO", "ReportDynamic");
		string text = MyReportInfo.DynReportFields.Trim();
		if (text.Trim().Length == 0)
		{
			return;
		}
		string[] array = text.Split(new char[1] { ',' });
		string text2 = "";
		int num5 = 10;
		int num6 = 4;
		int num7 = 104;
		checked
		{
			int num8 = array.Length - 1;
			Padding val6 = default(Padding);
			Point location;
			for (int i = 0; i <= num8; i++)
			{
				Control val = new Control();
				Label val2 = new Label();
				Label val3 = new Label();
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				decimal num9 = default(decimal);
				string text3 = "TEXTBOX";
				string text4 = "";
				string text5 = "";
				string text6 = "";
				string[] array2 = array[i].Split(new char[1] { ':' });
				text2 = array2[0].Trim();
				val.Name = "txt" + text2;
				((Control)val3).Name = "lblName" + text2;
				int num10 = array2.Length - 1;
				for (int j = 1; j <= num10; j++)
				{
					if (array2[j].ToUpper().StartsWith("L="))
					{
						text5 = Strings.Right(array2[j], Strings.Len(array2[j]) - 2);
					}
					if (array2[j].ToUpper().StartsWith("D="))
					{
						text6 = Strings.Right(array2[j], Strings.Len(array2[j]) - 2);
					}
					if (array2[j].Equals("*"))
					{
						flag2 = true;
					}
					if (array2[j].ToUpper().StartsWith("W="))
					{
						num9 = Conversions.ToDecimal(Helper.Repl_Null(Strings.Right(array2[j], Strings.Len(array2[j]) - 2), isNum: true));
					}
					if (array2[j].ToUpper().StartsWith("T="))
					{
						text3 = Strings.Right(array2[j], Strings.Len(array2[j]) - 2);
					}
					if (array2[j].ToUpper().StartsWith("RADIO"))
					{
						text3 = "RADIO";
						if (array2[j].ToUpper().StartsWith("RADIO="))
						{
							text4 = Strings.Right(array2[j], Strings.Len(array2[j]) - 6);
						}
					}
					if (array2[j].ToUpper().StartsWith("CHECKBOX"))
					{
						text3 = "CHECKBOX";
						if (array2[j].ToUpper().StartsWith("CHECKBOX="))
						{
							text4 = Strings.Right(array2[j], Strings.Len(array2[j]) - 9);
						}
					}
					if (array2[j].ToUpper().StartsWith("COMBOBOX"))
					{
						text3 = "COMBOBOX";
						if (array2[j].ToUpper().StartsWith("COMBOBOX="))
						{
							text4 = Strings.Right(array2[j], Strings.Len(array2[j]) - 9);
						}
					}
					if (array2[j].ToUpper().StartsWith("LOOKUPWHERE="))
					{
						text4 = Strings.Right(array2[j], Strings.Len(array2[j]) - 12);
						text4 = text4.Replace("(", "");
						text4 = text4.Replace(")", "");
					}
				}
				if (lookupList.ToUpper().Contains(text2))
				{
					text3 = "LOOKUP";
				}
				switch (text3.ToUpper())
				{
				case "LOOKUP":
				{
					num5 = 10;
					((Control)val2).Name = "lbl" + text2;
					val2.Text = text5;
					location = new Point(x, num7 + num5);
					((Control)val2).Location = location;
					val2.AutoSize = true;
					val = (Control)(object)new AsTextBox();
					((AsTextBox)(object)val).AutoLookup = true;
					((TextBox)(AsTextBox)(object)val).CharacterCasing = (CharacterCasing)1;
					((AsTextBox)(object)val).LookupCodeName = text2;
					((AsTextBox)(object)val).LookupWhereCondition = text4;
					((AsTextBox)(object)val).NameControl = val3;
					((AsTextBox)(object)val).UseAutoCompleteSource = true;
					Control obj7 = val;
					location = new Point(num2, num7 + 5);
					obj7.Location = location;
					val.BackColor = SystemColors.Info;
					val.Name = "txt" + text2;
					Control obj8 = val;
					Size size = new Size(Conversions.ToInteger(Interaction.IIf(decimal.Compare(num9, 0m) == 0, (object)90m, (object)num9)), 20);
					obj8.Size = size;
					val.TabIndex = num6;
					val.Tag = text2;
					num6++;
					val.Text = text6;
					((Control)tabFilter).Controls.Add((Control)(object)val2);
					((Control)tabFilter).Controls.Add(val);
					location = new Point(num2 + val.Width + 5, num7 + num5);
					((Control)val3).Location = location;
					val3.AutoSize = true;
					LookupInformation lookupInformation = AsiaErp.Framework.Environment.GetLookupInformation(text2);
					((Control)tabFilter).Controls.Add((Control)(object)val3);
					DataRow pDrw = null;
					if (Operators.CompareString(lookupInformation.Dictionary, "1", false) == 0)
					{
						if (Commons.ValidMa(ref pDrw, lookupInformation.code_name, text6, "", AsiaErp.Framework.Environment.GetDictionaryInformation(text2).name_fname, pSd: true))
						{
							val3.Text = Helper.Repl_Null(RuntimeHelpers.GetObjectValue(pDrw[AsiaErp.Framework.Environment.GetDictionaryInformation(text2).name_fname]), isNum: false).ToString();
						}
					}
					else if (Operators.CompareString(lookupInformation.Dictionary, "2", false) == 0 && Commons.ValidMaComplex(ref pDrw, lookupInformation.code_name, text6, "", AsiaErp.Framework.Environment.GetDictionaryComplexInformation(text2).name_fname, pSd: true))
					{
						val3.Text = Helper.Repl_Null(RuntimeHelpers.GetObjectValue(pDrw[AsiaErp.Framework.Environment.GetDictionaryComplexInformation(text2).name_fname]), isNum: false).ToString();
					}
					num7 = num7 + 5 + val.Height;
					break;
				}
				case "TEXTBOX":
				{
					val = (Control)new TextBox();
					val.TabIndex = num6;
					num6++;
					num5 = 10;
					((Control)val2).Name = "lbl" + text2;
					val2.Text = text5;
					location = new Point(x, num7 + num5);
					((Control)val2).Location = location;
					val2.AutoSize = true;
					Control obj5 = val;
					location = new Point(num2, num7 + 5);
					obj5.Location = location;
					val.BackColor = SystemColors.Window;
					val.Name = "txt" + text2;
					Control obj6 = val;
					Size size = new Size(Conversions.ToInteger(Interaction.IIf(decimal.Compare(num9, 0m) == 0, (object)330m, (object)num9)), 20);
					obj6.Size = size;
					val.Text = text6;
					((Control)tabFilter).Controls.Add((Control)(object)val2);
					((Control)tabFilter).Controls.Add(val);
					num7 = num7 + 5 + val.Height;
					break;
				}
				case "CHECKBOX":
				{
					val = (Control)new CheckBox();
					val.TabIndex = num6;
					num6++;
					num5 = 10;
					((Control)val2).Name = "lbl" + text2;
					val2.Text = text5;
					location = new Point(x, num7 + num5);
					((Control)val2).Location = location;
					val2.AutoSize = true;
					Control obj9 = val;
					location = new Point(num2, num7 + 5);
					obj9.Location = location;
					val.BackColor = SystemColors.Window;
					val.Name = "chk" + text2;
					val.Tag = text4;
					val.Text = text5;
					Control obj10 = val;
					Size size = new Size(Conversions.ToInteger(Interaction.IIf(decimal.Compare(num9, 0m) == 0, (object)90m, (object)num9)), 20);
					obj10.Size = size;
					((CheckBox)val).Checked = true;
					((Control)tabFilter).Controls.Add(val);
					((Control)tabFilter).Controls.Add((Control)(object)val2);
					num7 = num7 + 5 + val.Height;
					break;
				}
				case "RADIO":
				{
					string[] array6 = text4.Split(new char[1] { '/' });
					val = (Control)new GroupBox();
					num5 = 25;
					((Control)val2).Name = "lbl" + text2;
					val2.Text = text5;
					location = new Point(x, num7 + num5);
					((Control)val2).Location = location;
					val2.AutoSize = true;
					int num13 = 1;
					int num14 = 5;
					string[] array7 = array6;
					foreach (string text8 in array7)
					{
						RadioButton val5 = new RadioButton();
						location = new Point(num14, 20);
						((Control)val5).Location = location;
						((Padding)(ref val6))._002Ector(0);
						((Control)val5).Margin = val6;
						((Control)val5).Name = "rad" + text2 + Conversions.ToString(num13);
						((Control)val5).Tag = text8;
						((ButtonBase)val5).Text = text8;
						val5.CheckedChanged += RadioButton_CheckedChanged;
						((Control)val5).Width = text5.Length * 12;
						num14 += ((Control)val5).Width;
						val.Controls.Add((Control)(object)val5);
						if (num13 == 1)
						{
							val5.Checked = true;
						}
						num13++;
					}
					val.TabIndex = num6;
					num6++;
					val.AutoSize = true;
					Control obj2 = val;
					((Padding)(ref val6))._002Ector(0);
					obj2.Margin = val6;
					Control obj3 = val;
					((Padding)(ref val6))._002Ector(0);
					obj3.Padding = val6;
					Control obj4 = val;
					location = new Point(num2, num7 + 5);
					obj4.Location = location;
					val.Height = 45;
					((Control)tabFilter).Controls.Add(val);
					((Control)tabFilter).Controls.Add((Control)(object)val2);
					num7 = num7 + 5 + val.Height;
					break;
				}
				case "COMBOBOX":
				{
					val = (Control)new ComboBox();
					val.TabIndex = num6;
					num6++;
					num5 = 10;
					((Control)val2).Name = "lbl" + text2;
					val2.Text = text5;
					location = new Point(x, num7 + num5);
					((Control)val2).Location = location;
					val2.AutoSize = true;
					((ComboBox)val).DropDownStyle = (ComboBoxStyle)2;
					Control obj = val;
					location = new Point(num2, num7 + 5);
					obj.Location = location;
					val.BackColor = SystemColors.Window;
					val.Name = "cbo" + text2;
					val.Tag = text4;
					val.Text = text5;
					ArrayList arrayList = new ArrayList();
					string[] array3 = text4.Split(new char[1] { '/' });
					int num11 = 0;
					string[] array4 = array3;
					foreach (string text7 in array4)
					{
						if (text7.Length > num11)
						{
							num11 = text7.Length;
						}
					}
					val.Width = num11 * 7;
					int num12 = 0;
					DataTable dataTable = new DataTable();
					dataTable.Columns.Add("Key");
					dataTable.Columns.Add("Value");
					string[] array5 = array3;
					foreach (string value in array5)
					{
						DataRow dataRow = dataTable.NewRow();
						dataRow["Key"] = value;
						dataRow["Value"] = value;
						dataTable.Rows.Add(dataRow);
					}
					ComboBox val4 = (ComboBox)val;
					val4.DataSource = dataTable;
					((ListControl)val4).ValueMember = "Key";
					((ListControl)val4).DisplayMember = "Value";
					val4 = null;
					((Control)tabFilter).Controls.Add((Control)(object)val2);
					((Control)tabFilter).Controls.Add(val);
					num7 = num7 + 5 + val.Height;
					break;
				}
				}
				f_arrParControls.Add(val);
				f_arrLabelControls.Add(val2);
				if (flag2)
				{
					f_arrParRequired.Add(val);
				}
			}
			((Control)cmdOk).TabIndex = num6;
			((Control)cboMau_bc).TabIndex = num6 + 1;
			((Control)txtTieu_De).TabIndex = num6 + 2;
			Label obj11 = lblMauBC;
			location = new Point(x, num7 + num5);
			((Control)obj11).Location = location;
			RadioButton obj12 = optVND;
			location = new Point(num2, num7 + num5);
			((Control)obj12).Location = location;
			RadioButton obj13 = optNt;
			location = new Point(x2, num7 + num5);
			((Control)obj13).Location = location;
			Button obj14 = cmdOk;
			location = new Point(x, num7 + num5 + 25);
			((Control)obj14).Location = location;
		}
	}

	protected override bool LoadData()
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		foreach (Control f_arrParControl in f_arrParControls)
		{
			if (((object)((object)f_arrParControl).GetType() == typeof(AsTextBox)) | ((object)((object)f_arrParControl).GetType() == typeof(TextBox)))
			{
				arrayList.Add(f_arrParControl.Text);
			}
			if ((object)((object)f_arrParControl).GetType() == typeof(CheckBox))
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(((Control)(CheckBox)f_arrParControl).Tag));
			}
			if ((object)((object)f_arrParControl).GetType() == typeof(GroupBox))
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(((Control)(GroupBox)f_arrParControl).Tag));
			}
			if ((object)((object)f_arrParControl).GetType() == typeof(ComboBox))
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)(ComboBox)f_arrParControl).SelectedValue));
			}
		}
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	protected override bool ValidData()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		string empty = string.Empty;
		string text = string.Empty;
		string text2 = string.Empty;
		int num = 0;
		string text3 = string.Empty;
		foreach (Control f_arrParControl in f_arrParControls)
		{
			if ((object)((object)f_arrParControl).GetType() == typeof(AsTextBox))
			{
				text3 = f_arrParControl.Text;
				Control[] array = ((Control)this).Controls.Find("lblName" + f_arrParControl.Tag.ToString(), true);
				if (array.Length > 0)
				{
					text3 = text3 + "-" + ((Label)array[0]).Text;
				}
			}
			if ((object)((object)f_arrParControl).GetType() == typeof(TextBox))
			{
				text3 = f_arrParControl.Text;
			}
			if ((object)((object)f_arrParControl).GetType() == typeof(CheckBox))
			{
				text3 = ((Control)(CheckBox)f_arrParControl).Tag.ToString();
			}
			if ((object)((object)f_arrParControl).GetType() == typeof(GroupBox))
			{
				text3 = ((Control)(GroupBox)f_arrParControl).Tag.ToString();
			}
			if ((object)((object)f_arrParControl).GetType() == typeof(ComboBox))
			{
				text3 = ((ListControl)(ComboBox)f_arrParControl).SelectedValue.ToString();
			}
			if (f_arrParRequired.Contains(f_arrParControl))
			{
				text = text + f_arrLabelControls[num].Text + ":[" + text3 + "];";
			}
			else if (Operators.CompareString(text3, "", false) != 0)
			{
				text2 = text2 + f_arrLabelControls[num].Text + ":[" + text3 + "];";
			}
			num = checked(num + 1);
		}
		FilterTitle = text;
		SubFilterTitle = text2;
		return empty;
	}

	private void frmReportDynamic_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 13)
		{
			SendKeys.Send("{TAB}");
		}
	}

	private void RadioButton_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if (((RadioButton)sender).Checked)
		{
			((Control)(GroupBox)((Control)(RadioButton)sender).Parent).Tag = RuntimeHelpers.GetObjectValue(((Control)(RadioButton)sender).Tag);
		}
	}
}
