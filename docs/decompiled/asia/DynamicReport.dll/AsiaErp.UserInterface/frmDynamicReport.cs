using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
public class frmDynamicReport : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	private const decimal W_TEXT = 330m;

	private const decimal W_LOOK = 90m;

	private const decimal W_DROP = 90m;

	private const decimal W_CHECK = 90m;

	private const decimal W_DATETIME = 67m;

	private const decimal W_RADIO = 396m;

	private const int H_ALING_TEXT = 10;

	private const int H_ALING_GROUP = 25;

	private const int LBL_X = 24;

	private const int CONTROL_X = 110;

	private const int LBL_NAME_X = 202;

	private List<Control> f_arrParRequired;

	private List<Control> f_arrParControls;

	private List<Label> f_arrLabelControls;

	private List<Control> f_arrAllControlFilterCustom;

	private bool f_blnIsLoading;

	private int f_Y_Value;

	protected override ComboBox cboMau_bc
	{
		[DebuggerNonUserCode]
		get
		{
			return base.cboMau_bc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboMau_bc_SelectedIndexChanged;
			if (base.cboMau_bc != null)
			{
				base.cboMau_bc.SelectedIndexChanged -= eventHandler;
			}
			base.cboMau_bc = value;
			if (base.cboMau_bc != null)
			{
				base.cboMau_bc.SelectedIndexChanged += eventHandler;
			}
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

	public frmDynamicReport(string MenuID)
		: base(MenuID)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmReportDynamic_KeyDown);
		((Form)this).Load += frmDynamicReport_Load;
		__ENCAddToList(this);
		f_arrParRequired = new List<Control>();
		f_arrParControls = new List<Control>();
		f_arrLabelControls = new List<Label>();
		f_arrAllControlFilterCustom = new List<Control>();
		f_blnIsLoading = true;
		f_Y_Value = 104;
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
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
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
		location = new Point(804, 159);
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
		location = new Point(723, 159);
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
		((Control)this).Name = "frmDynamicReport";
		((Form)this).Text = "";
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmDynamicReport_Load(object sender, EventArgs e)
	{
		f_blnIsLoading = true;
		DrawingFilterControl();
		f_blnIsLoading = false;
	}

	private void cboMau_bc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (f_blnIsLoading || cboMau_bc.DataSource == null)
		{
			return;
		}
		foreach (Control item in f_arrAllControlFilterCustom)
		{
			if (((Control)tabFilter).Controls.ContainsKey(item.Name))
			{
				((Control)tabFilter).Controls.Remove(item);
			}
		}
		f_arrAllControlFilterCustom.Clear();
		f_arrLabelControls.Clear();
		f_arrParControls.Clear();
		f_arrParRequired.Clear();
		DrawingFilterControl();
	}

	protected override bool LoadData()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
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
				arrayList.Add(((CheckBox)f_arrParControl).Checked);
			}
			if ((object)((object)f_arrParControl).GetType() == typeof(AsMaskedTextBox))
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(((AsMaskedTextBox)(object)f_arrParControl).Value));
			}
			if ((object)((object)f_arrParControl).GetType() == typeof(AsTextNumeric))
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(((AsTextNumeric)(object)f_arrParControl).Value));
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
		GetFilterTitle();
		base.MyFomularFields.Add("strFilterTitle", FilterTitle);
		base.MyFomularFields.Add("strSubFilterTitle", SubFilterTitle);
		return true;
	}

	protected override bool ValidData()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		foreach (TextBox item in f_arrParRequired)
		{
			TextBox txt = item;
			if (!ChkEmtyTextBox(txt))
			{
				return false;
			}
			epNotice.Clear();
		}
		return base.ValidData();
	}

	private void frmReportDynamic_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 13)
		{
			SendKeys.Send("{TAB}");
		}
	}

	private void RadioButton_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (((RadioButton)sender).Checked)
		{
			((Control)(GroupBox)((Control)(RadioButton)sender).Parent).Tag = RuntimeHelpers.GetObjectValue(((Control)(RadioButton)sender).Tag);
		}
	}

	private void GetFilterTitle()
	{
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
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
				if (array.Length > 0 && Operators.CompareString(text3.Trim(), "", false) != 0)
				{
					text3 = text3 + "-" + ((Label)array[0]).Text;
				}
			}
			if ((object)((object)f_arrParControl).GetType() == typeof(TextBox))
			{
				text3 = f_arrParControl.Text;
			}
			if ((object)((object)f_arrParControl).GetType() == typeof(CheckBox) && ((CheckBox)f_arrParControl).Checked)
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
				text2 = (((object)((object)f_arrParControl).GetType() != typeof(CheckBox)) ? (text2 + f_arrLabelControls[num].Text + ":[" + text3 + "];") : (text2 + f_arrLabelControls[num].Text + ";"));
			}
			num = checked(num + 1);
		}
		FilterTitle = text;
		SubFilterTitle = text2;
	}

	public void InitAsTextBox(string fieldName, string textLabel, string sWhere, string defaultValue, bool blnReadOnly, bool blnRequire, ref int tabOrder, decimal width, int H_ALIGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		Label val = new Label();
		AsTextBox asTextBox = new AsTextBox();
		Label val2 = new Label();
		((Control)val).Name = "lbl" + fieldName;
		val.Text = textLabel;
		checked
		{
			Point location = new Point(24, f_Y_Value + H_ALIGN);
			((Control)val).Location = location;
			val.AutoSize = true;
			((Control)asTextBox).Name = "txt" + fieldName;
			asTextBox.AutoLookup = true;
			((TextBox)asTextBox).CharacterCasing = (CharacterCasing)1;
			asTextBox.LookupCodeName = fieldName;
			asTextBox.LookupWhereCondition = sWhere;
			asTextBox.NameControl = val2;
			asTextBox.UseAutoCompleteSource = true;
			location = new Point(110, f_Y_Value + 5);
			((Control)asTextBox).Location = location;
			((TextBoxBase)asTextBox).BackColor = SystemColors.Info;
			((Control)asTextBox).Name = "txt" + fieldName;
			Size size = new Size(Conversions.ToInteger(Interaction.IIf(decimal.Compare(width, 0m) == 0, (object)90m, (object)width)), 20);
			((Control)asTextBox).Size = size;
			((Control)asTextBox).TabIndex = tabOrder;
			tabOrder++;
			((Control)asTextBox).Tag = fieldName;
			((Control)asTextBox).Enabled = blnReadOnly;
			((TextBox)asTextBox).Text = defaultValue;
			DictionaryInformation dictionaryInformation = AsiaErp.Framework.Environment.GetDictionaryInformation(fieldName);
			asTextBox.ValidReturnFieldList = dictionaryInformation.name_fname;
			((Control)val2).Name = "lblName" + fieldName;
			location = new Point(110 + ((Control)asTextBox).Width + 5, f_Y_Value + H_ALIGN);
			((Control)val2).Location = location;
			val2.AutoSize = true;
			((Control)tabFilter).Controls.Add((Control)(object)val);
			((Control)tabFilter).Controls.Add((Control)(object)asTextBox);
			((Control)tabFilter).Controls.Add((Control)(object)val2);
			f_arrAllControlFilterCustom.Add((Control)(object)val);
			f_arrAllControlFilterCustom.Add((Control)(object)asTextBox);
			f_arrAllControlFilterCustom.Add((Control)(object)val2);
			f_arrParControls.Add((Control)(object)asTextBox);
			f_arrLabelControls.Add(val);
			if (blnRequire)
			{
				f_arrParRequired.Add((Control)(object)asTextBox);
			}
			asTextBox.MyValid();
			tabOrder++;
			f_Y_Value = f_Y_Value + 5 + ((Control)asTextBox).Height;
		}
	}

	public void InitTextBox(string fieldName, string textLabel, string defaultValue, bool blnReadOnly, bool blnRequire, ref int tabOrder, decimal width, int H_ALIGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		Label val = new Label();
		TextBox val2 = new TextBox();
		((Control)val).Name = "lbl" + fieldName;
		val.Text = textLabel;
		checked
		{
			Point location = new Point(24, f_Y_Value + H_ALIGN);
			((Control)val).Location = location;
			val.AutoSize = true;
			((Control)val2).Name = "txt" + fieldName;
			((Control)val2).TabIndex = tabOrder;
			val2.Text = defaultValue;
			location = new Point(110, f_Y_Value + 5);
			((Control)val2).Location = location;
			((TextBoxBase)val2).BackColor = SystemColors.Window;
			Size size = new Size(Conversions.ToInteger(Interaction.IIf(decimal.Compare(width, 0m) == 0, (object)330m, (object)width)), 20);
			((Control)val2).Size = size;
			((Control)val2).Enabled = blnReadOnly;
			((Control)tabFilter).Controls.Add((Control)(object)val);
			((Control)tabFilter).Controls.Add((Control)(object)val2);
			f_arrAllControlFilterCustom.Add((Control)(object)val);
			f_arrAllControlFilterCustom.Add((Control)(object)val2);
			f_arrParControls.Add((Control)(object)val2);
			f_arrLabelControls.Add(val);
			if (blnRequire)
			{
				f_arrParRequired.Add((Control)(object)val2);
			}
			tabOrder++;
			f_Y_Value = f_Y_Value + 5 + ((Control)val2).Height;
		}
	}

	public void InitCheckBox(string fieldName, string textLabel, string source, string defaultValue, bool blnReadOnly, bool blnRequire, ref int tabOrder, decimal width, int H_ALIGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		Label val = new Label();
		CheckBox val2 = new CheckBox();
		((Control)val).Name = "lbl" + fieldName;
		val.Text = textLabel;
		checked
		{
			Point location = new Point(24, f_Y_Value + H_ALIGN);
			((Control)val).Location = location;
			val.AutoSize = true;
			((Control)val2).TabIndex = tabOrder;
			((Control)val2).Name = "chk" + fieldName;
			location = new Point(110, f_Y_Value + 5);
			((Control)val2).Location = location;
			((ButtonBase)val2).BackColor = SystemColors.Window;
			((Control)val2).Tag = source;
			((ButtonBase)val2).Text = textLabel;
			Size size = new Size(Conversions.ToInteger(Interaction.IIf(decimal.Compare(width, 0m) == 0, (object)90m, (object)width)), 20);
			((Control)val2).Size = size;
			((Control)val2).Enabled = blnReadOnly;
			val2.Checked = true;
			((Control)tabFilter).Controls.Add((Control)(object)val2);
			((Control)tabFilter).Controls.Add((Control)(object)val);
			f_arrAllControlFilterCustom.Add((Control)(object)val);
			f_arrAllControlFilterCustom.Add((Control)(object)val2);
			f_arrParControls.Add((Control)(object)val2);
			f_arrLabelControls.Add(val);
			if (blnRequire)
			{
				f_arrParRequired.Add((Control)(object)val2);
			}
			tabOrder++;
			f_Y_Value = f_Y_Value + 5 + ((Control)val2).Height;
		}
	}

	public void InitRadioButton(string fieldName, string textLabel, string source, string defaultValue, bool blnReadOnly, bool blnRequire, ref int tabOrder, decimal width, int H_ALIGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		Label val = new Label();
		GroupBox val2 = new GroupBox();
		((Control)val).Name = "lbl" + fieldName;
		val.Text = textLabel;
		checked
		{
			Point location = new Point(24, f_Y_Value + H_ALIGN);
			((Control)val).Location = location;
			val.AutoSize = true;
			string[] array = source.Split(new char[1] { '/' });
			int num = 1;
			int num2 = 5;
			string[] array2 = array;
			Padding val4 = default(Padding);
			foreach (string text in array2)
			{
				RadioButton val3 = new RadioButton();
				location = new Point(num2, 20);
				((Control)val3).Location = location;
				((Padding)(ref val4))._002Ector(0);
				((Control)val3).Margin = val4;
				((Control)val3).Name = "rad" + fieldName + Conversions.ToString(num);
				((Control)val3).Tag = text;
				((ButtonBase)val3).Text = text;
				val3.CheckedChanged += RadioButton_CheckedChanged;
				((Control)val3).Width = textLabel.Length * 12;
				num2 += ((Control)val3).Width;
				((Control)val2).Controls.Add((Control)(object)val3);
				if (num == 1)
				{
					val3.Checked = true;
				}
				num++;
			}
			((Control)val2).TabIndex = tabOrder;
			val2.AutoSize = true;
			((Padding)(ref val4))._002Ector(0);
			((Control)val2).Margin = val4;
			((Padding)(ref val4))._002Ector(0);
			((Control)val2).Padding = val4;
			location = new Point(110, f_Y_Value + 5);
			((Control)val2).Location = location;
			((Control)val2).Height = 45;
			((Control)val2).Enabled = blnReadOnly;
			((Control)tabFilter).Controls.Add((Control)(object)val2);
			((Control)tabFilter).Controls.Add((Control)(object)val);
			f_arrAllControlFilterCustom.Add((Control)(object)val);
			f_arrAllControlFilterCustom.Add((Control)(object)val2);
			f_arrParControls.Add((Control)(object)val2);
			f_arrLabelControls.Add(val);
			if (blnRequire)
			{
				f_arrParRequired.Add((Control)(object)val2);
			}
			f_Y_Value = f_Y_Value + 5 + ((Control)val2).Height;
			tabOrder++;
		}
	}

	public void InitComboBox(string fieldName, string textLabel, string source, string defaultValue, bool blnReadOnly, bool blnRequire, ref int tabOrder, decimal width, int H_ALIGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		Label val = new Label();
		ComboBox val2 = new ComboBox();
		((Control)val).Name = "lbl" + fieldName;
		val.Text = textLabel;
		checked
		{
			Point location = new Point(24, f_Y_Value + H_ALIGN);
			((Control)val).Location = location;
			val.AutoSize = true;
			((Control)val2).TabIndex = tabOrder;
			val2.DropDownStyle = (ComboBoxStyle)2;
			location = new Point(110, f_Y_Value + 5);
			((Control)val2).Location = location;
			val2.BackColor = SystemColors.Window;
			((Control)val2).Name = "cbo" + fieldName;
			((Control)val2).Tag = source;
			val2.Text = textLabel;
			((Control)val2).Enabled = blnReadOnly;
			ArrayList arrayList = new ArrayList();
			string[] array = source.Split(new char[1] { '/' });
			int num = 0;
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (text.Length > num)
				{
					num = text.Length;
				}
			}
			((Control)val2).Width = num * 7;
			int num2 = 0;
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Key");
			dataTable.Columns.Add("Value");
			string[] array3 = array;
			foreach (string value in array3)
			{
				DataRow dataRow = dataTable.NewRow();
				dataRow["Key"] = value;
				dataRow["Value"] = value;
				dataTable.Rows.Add(dataRow);
			}
			ComboBox val3 = val2;
			val3.DataSource = dataTable;
			((ListControl)val3).ValueMember = "Key";
			((ListControl)val3).DisplayMember = "Value";
			val3 = null;
			((Control)tabFilter).Controls.Add((Control)(object)val);
			((Control)tabFilter).Controls.Add((Control)(object)val2);
			f_arrAllControlFilterCustom.Add((Control)(object)val);
			f_arrAllControlFilterCustom.Add((Control)(object)val2);
			f_arrParControls.Add((Control)(object)val2);
			f_arrLabelControls.Add(val);
			if (blnRequire)
			{
				f_arrParRequired.Add((Control)(object)val2);
			}
			tabOrder++;
			f_Y_Value = f_Y_Value + 5 + ((Control)val2).Height;
		}
	}

	public void InitDateTime(string fieldName, string textLabel, string defaultValue, bool blnReadOnly, bool blnRequire, ref int tabOrder, decimal width, int H_ALIGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		Label val = new Label();
		AsMaskedTextBox asMaskedTextBox = new AsMaskedTextBox();
		((Control)val).Name = "lbl" + fieldName;
		val.Text = textLabel;
		checked
		{
			Point location = new Point(24, f_Y_Value + H_ALIGN);
			((Control)val).Location = location;
			val.AutoSize = true;
			((Control)asMaskedTextBox).Name = "txt" + fieldName;
			((Control)asMaskedTextBox).TabIndex = tabOrder;
			((MaskedTextBox)asMaskedTextBox).Text = defaultValue;
			location = new Point(110, f_Y_Value + 5);
			((Control)asMaskedTextBox).Location = location;
			((TextBoxBase)asMaskedTextBox).BackColor = SystemColors.Window;
			Size size = new Size(Conversions.ToInteger(Interaction.IIf(decimal.Compare(width, 0m) == 0, (object)67m, (object)width)), 20);
			((Control)asMaskedTextBox).Size = size;
			((Control)asMaskedTextBox).Enabled = blnReadOnly;
			asMaskedTextBox.Format = "@Ddd/MM/yyyy";
			((MaskedTextBox)asMaskedTextBox).Mask = "##/##/####";
			((MaskedTextBox)asMaskedTextBox).ValidatingType = typeof(DateTime);
			DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
			asMaskedTextBox.Value = dateTime;
			((Control)tabFilter).Controls.Add((Control)(object)val);
			((Control)tabFilter).Controls.Add((Control)(object)asMaskedTextBox);
			f_arrAllControlFilterCustom.Add((Control)(object)val);
			f_arrAllControlFilterCustom.Add((Control)(object)asMaskedTextBox);
			f_arrParControls.Add((Control)(object)asMaskedTextBox);
			f_arrLabelControls.Add(val);
			if (blnRequire)
			{
				f_arrParRequired.Add((Control)(object)asMaskedTextBox);
			}
			tabOrder++;
			f_Y_Value = f_Y_Value + 5 + ((Control)asMaskedTextBox).Height;
		}
	}

	public void InitQuantityTextBox(string fieldName, string textLabel, string defaultValue, bool blnReadOnly, bool blnRequire, ref int tabOrder, decimal width, int H_ALIGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		Label val = new Label();
		AsTextNumeric asTextNumeric = new AsTextNumeric();
		((Control)val).Name = "lbl" + fieldName;
		val.Text = textLabel;
		checked
		{
			Point location = new Point(24, f_Y_Value + H_ALIGN);
			((Control)val).Location = location;
			val.AutoSize = true;
			((Control)asTextNumeric).Name = "txt" + fieldName;
			((Control)asTextNumeric).TabIndex = tabOrder;
			((TextBox)asTextNumeric).Text = defaultValue;
			location = new Point(110, f_Y_Value + 5);
			((Control)asTextNumeric).Location = location;
			((TextBoxBase)asTextNumeric).BackColor = SystemColors.Window;
			Size size = new Size(Conversions.ToInteger(Interaction.IIf(decimal.Compare(width, 0m) == 0, (object)90m, (object)width)), 20);
			((Control)asTextNumeric).Size = size;
			((Control)asTextNumeric).Enabled = blnReadOnly;
			asTextNumeric.DecimalSymbol = AsiaErp.Framework.Environment.GetSIConfiguration().Decimal_Separator;
			asTextNumeric.HotKey = (Keys)13;
			asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Qty_Input_Format;
			asTextNumeric.SpecialType = Commons.NumericSpecialType.Other;
			((TextBox)asTextNumeric).Text = "0";
			((TextBox)asTextNumeric).TextAlign = (HorizontalAlignment)1;
			asTextNumeric.Value = 0;
			((Control)tabFilter).Controls.Add((Control)(object)val);
			((Control)tabFilter).Controls.Add((Control)(object)asTextNumeric);
			f_arrAllControlFilterCustom.Add((Control)(object)val);
			f_arrAllControlFilterCustom.Add((Control)(object)asTextNumeric);
			f_arrParControls.Add((Control)(object)asTextNumeric);
			f_arrLabelControls.Add(val);
			if (blnRequire)
			{
				f_arrParRequired.Add((Control)(object)asTextNumeric);
			}
			tabOrder++;
			f_Y_Value = f_Y_Value + 5 + ((Control)asTextNumeric).Height;
		}
	}

	public void InitAmountTextBox(string fieldName, string textLabel, string defaultValue, bool blnReadOnly, bool blnRequire, ref int tabOrder, decimal width, int H_ALIGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		Label val = new Label();
		AsTextNumeric asTextNumeric = new AsTextNumeric();
		((Control)val).Name = "lbl" + fieldName;
		val.Text = textLabel;
		checked
		{
			Point location = new Point(24, f_Y_Value + H_ALIGN);
			((Control)val).Location = location;
			val.AutoSize = true;
			((Control)asTextNumeric).Name = "txt" + fieldName;
			((Control)asTextNumeric).TabIndex = tabOrder;
			((TextBox)asTextNumeric).Text = defaultValue;
			location = new Point(110, f_Y_Value + 5);
			((Control)asTextNumeric).Location = location;
			((TextBoxBase)asTextNumeric).BackColor = SystemColors.Window;
			Size size = new Size(Conversions.ToInteger(Interaction.IIf(decimal.Compare(width, 0m) == 0, (object)90m, (object)width)), 20);
			((Control)asTextNumeric).Size = size;
			((Control)asTextNumeric).Enabled = blnReadOnly;
			asTextNumeric.DecimalSymbol = AsiaErp.Framework.Environment.GetSIConfiguration().Decimal_Separator;
			asTextNumeric.HotKey = (Keys)13;
			asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Price_Input_Format;
			asTextNumeric.SpecialType = Commons.NumericSpecialType.Other;
			((TextBox)asTextNumeric).Text = "0";
			((TextBox)asTextNumeric).TextAlign = (HorizontalAlignment)1;
			asTextNumeric.Value = 0;
			((Control)tabFilter).Controls.Add((Control)(object)val);
			((Control)tabFilter).Controls.Add((Control)(object)asTextNumeric);
			f_arrAllControlFilterCustom.Add((Control)(object)val);
			f_arrAllControlFilterCustom.Add((Control)(object)asTextNumeric);
			f_arrParControls.Add((Control)(object)asTextNumeric);
			f_arrLabelControls.Add(val);
			if (blnRequire)
			{
				f_arrParRequired.Add((Control)(object)asTextNumeric);
			}
			tabOrder++;
			f_Y_Value = f_Y_Value + 5 + ((Control)asTextNumeric).Height;
		}
	}

	public void InitTextBoxNumeric(string fieldName, string textLabel, string defaultValue, int decimals, bool blnReadOnly, bool blnRequire, ref int tabOrder, decimal width, int H_ALIGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		Label val = new Label();
		AsTextNumeric asTextNumeric = new AsTextNumeric();
		((Control)val).Name = "lbl" + fieldName;
		val.Text = textLabel;
		checked
		{
			Point location = new Point(24, f_Y_Value + H_ALIGN);
			((Control)val).Location = location;
			val.AutoSize = true;
			((Control)asTextNumeric).Name = "txt" + fieldName;
			((Control)asTextNumeric).TabIndex = tabOrder;
			((TextBox)asTextNumeric).Text = defaultValue;
			location = new Point(110, f_Y_Value + 5);
			((Control)asTextNumeric).Location = location;
			((TextBoxBase)asTextNumeric).BackColor = SystemColors.Window;
			Size size = new Size(Conversions.ToInteger(Interaction.IIf(decimal.Compare(width, 0m) == 0, (object)90m, (object)width)), 20);
			((Control)asTextNumeric).Size = size;
			((Control)asTextNumeric).Enabled = blnReadOnly;
			asTextNumeric.DecimalSymbol = AsiaErp.Framework.Environment.GetSIConfiguration().Decimal_Separator;
			asTextNumeric.HotKey = (Keys)13;
			string text = "### ### ### ###";
			if (decimals > 0)
			{
				text += AsiaErp.Framework.Environment.GetSIConfiguration().Decimal_Separator;
				int num = 1;
				while (true)
				{
					int num2 = num;
					int num3 = decimals;
					if (num2 > num3)
					{
						break;
					}
					text += "#";
					num++;
				}
			}
			asTextNumeric.Mask = text;
			asTextNumeric.SpecialType = Commons.NumericSpecialType.Other;
			((TextBox)asTextNumeric).Text = "0";
			((TextBox)asTextNumeric).TextAlign = (HorizontalAlignment)1;
			asTextNumeric.Value = 0;
			((Control)tabFilter).Controls.Add((Control)(object)val);
			((Control)tabFilter).Controls.Add((Control)(object)asTextNumeric);
			f_arrAllControlFilterCustom.Add((Control)(object)val);
			f_arrAllControlFilterCustom.Add((Control)(object)asTextNumeric);
			f_arrParControls.Add((Control)(object)asTextNumeric);
			f_arrLabelControls.Add(val);
			if (blnRequire)
			{
				f_arrParRequired.Add((Control)(object)asTextNumeric);
			}
			tabOrder++;
			f_Y_Value = f_Y_Value + 5 + ((Control)asTextNumeric).Height;
		}
	}

	protected void DrawingFilterControl()
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		string lookupList = AsiaErp.Framework.Environment.GetSIConfiguration().LookupList;
		DynamicReportDAO dynamicReportDAO = (DynamicReportDAO)DAOFactory.CreateDAOInstance("DynamicReportDAO", "DynamicReport");
		string text = MyReportInfo.DynReportFields.Trim();
		if (text.Trim().Length == 0)
		{
			return;
		}
		string[] array = text.Split(new char[1] { ';' });
		string text2 = "";
		int num = 10;
		int tabOrder = 4;
		SqlParameterCollection storeParameterInfo = dynamicReportDAO.GetStoreParameterInfo(base.MyReportInfo.spname);
		checked
		{
			int num2 = array.Length - 1;
			int num3 = 0;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				Control val = new Control();
				Label val2 = new Label();
				Label val3 = new Label();
				bool flag = false;
				bool blnRequire = false;
				bool flag2 = false;
				decimal width = default(decimal);
				string text3 = "TEXTBOX";
				string text4 = "";
				string textLabel = "";
				string defaultValue = "";
				bool blnReadOnly = true;
				int decimals = 0;
				string[] array2 = array[num3].Trim().Split(new char[1] { ':' });
				text2 = array2[0].Trim();
				val.Name = "txt" + text2;
				((Control)val3).Name = "lblName" + text2;
				int num6 = array2.Length - 1;
				int num7 = 1;
				while (true)
				{
					int num8 = num7;
					num5 = num6;
					if (num8 > num5)
					{
						break;
					}
					if (array2[num7].Trim().ToUpper().StartsWith("L="))
					{
						textLabel = Strings.Right(array2[num7], Strings.Len(array2[num7]) - 2);
					}
					if (array2[num7].Trim().Equals("*"))
					{
						blnRequire = true;
					}
					if (array2[num7].Trim().ToUpper().StartsWith("W="))
					{
						width = Conversions.ToDecimal(Helper.Repl_Null(Strings.Right(array2[num7], Strings.Len(array2[num7]) - 2), isNum: true));
					}
					if (array2[num7].Trim().ToUpper().StartsWith("T="))
					{
						text3 = Strings.Right(array2[num7], Strings.Len(array2[num7]) - 2);
					}
					if (array2[num7].Trim().ToUpper().StartsWith("D="))
					{
						defaultValue = Strings.Right(array2[num7], Strings.Len(array2[num7]) - 2);
					}
					if (Operators.CompareString(array2[num7].Trim().ToUpper(), "R", false) == 0)
					{
						blnReadOnly = false;
					}
					if (array2[num7].Trim().ToUpper().StartsWith("RADIO"))
					{
						text3 = "RADIO";
						if (array2[num7].ToUpper().StartsWith("RADIO="))
						{
							text4 = Strings.Right(array2[num7], Strings.Len(array2[num7]) - 6);
						}
					}
					if (array2[num7].Trim().ToUpper().StartsWith("COMBOBOX"))
					{
						text3 = "COMBOBOX";
						if (array2[num7].ToUpper().StartsWith("COMBOBOX="))
						{
							text4 = Strings.Right(array2[num7], Strings.Len(array2[num7]) - 9);
						}
					}
					if (storeParameterInfo[num3 + 4].DbType == DbType.Boolean)
					{
						text3 = "CHECKBOX";
					}
					if ((storeParameterInfo[num3 + 4].DbType == DbType.Decimal || storeParameterInfo[num3 + 4].DbType == DbType.Double || storeParameterInfo[num3 + 4].DbType == DbType.Int16 || storeParameterInfo[num3 + 4].DbType == DbType.Int32 || storeParameterInfo[num3 + 4].DbType == DbType.Int64) ? true : false)
					{
						text3 = "NUMERIC";
						decimals = storeParameterInfo[num3 + 4].Scale;
					}
					if (storeParameterInfo[num3 + 4].DbType == DbType.DateTime || storeParameterInfo[num3 + 4].DbType == DbType.DateTime2)
					{
						text3 = "DATETIME";
					}
					if (array2[num7].Trim().ToUpper().StartsWith("LOOKUPWHERE="))
					{
						text4 = Strings.Right(array2[num7], Strings.Len(array2[num7]) - 12);
						text4 = text4.Replace("(", "");
						text4 = text4.Replace(")", "");
					}
					num7++;
				}
				if (lookupList.ToUpper().Contains(text2))
				{
					text3 = "LOOKUP";
				}
				switch (text3.ToUpper())
				{
				case "LOOKUP":
					InitAsTextBox(text2, textLabel, text4, defaultValue, blnReadOnly, blnRequire, ref tabOrder, width, 10);
					break;
				case "TEXTBOX":
					InitTextBox(text2, textLabel, defaultValue, blnReadOnly, blnRequire, ref tabOrder, width, 10);
					break;
				case "CHECKBOX":
					InitCheckBox(text2, textLabel, text4, defaultValue, blnReadOnly, blnRequire, ref tabOrder, width, 10);
					break;
				case "RADIO":
					InitRadioButton(text2, textLabel, text4, defaultValue, blnReadOnly, blnRequire, ref tabOrder, width, 25);
					break;
				case "COMBOBOX":
					InitComboBox(text2, textLabel, text4, defaultValue, blnReadOnly, blnRequire, ref tabOrder, width, 10);
					break;
				case "DATETIME":
					InitDateTime(text2, textLabel, defaultValue, blnReadOnly, blnRequire, ref tabOrder, width, 10);
					break;
				case "NUMERIC":
					InitTextBoxNumeric(text2, textLabel, defaultValue, decimals, blnReadOnly, blnRequire, ref tabOrder, width, 10);
					break;
				}
				num3++;
			}
			((Control)cmdOk).TabIndex = tabOrder;
			((Control)cboMau_bc).TabIndex = tabOrder + 1;
			((Control)txtTieu_De).TabIndex = tabOrder + 2;
			Label obj = lblMauBC;
			Point location = new Point(24, f_Y_Value + num);
			((Control)obj).Location = location;
			RadioButton obj2 = optVND;
			location = new Point(110, f_Y_Value + num);
			((Control)obj2).Location = location;
			RadioButton obj3 = optNt;
			location = new Point(202, f_Y_Value + num);
			((Control)obj3).Location = location;
			Button obj4 = cmdOk;
			location = new Point(24, f_Y_Value + num + 25);
			((Control)obj4).Location = location;
		}
	}
}
