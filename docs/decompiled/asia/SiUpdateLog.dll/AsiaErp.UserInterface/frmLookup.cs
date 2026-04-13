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
using My.Resources;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmLookup : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cmdEdit")]
	private Button _cmdEdit;

	[AccessedThroughProperty("cmdAdd")]
	private Button _cmdAdd;

	[AccessedThroughProperty("txtCode_search")]
	private TextBox _txtCode_search;

	[AccessedThroughProperty("txtSearch")]
	private TextBox _txtSearch;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("adgvcID")]
	private DataGridViewTextBoxColumn _adgvcID;

	[AccessedThroughProperty("adgvcBugNumber")]
	private DataGridViewTextBoxColumn _adgvcBugNumber;

	[AccessedThroughProperty("adgvcDescription")]
	private DataGridViewTextBoxColumn _adgvcDescription;

	[AccessedThroughProperty("adgvcNote")]
	private DataGridViewTextBoxColumn _adgvcNote;

	[AccessedThroughProperty("adgvcLinkNumber")]
	private DataGridViewTextBoxColumn _adgvcLinkNumber;

	[AccessedThroughProperty("adgvDM")]
	private AsDataGridView _adgvDM;

	private string f_strCodeValue;

	private int f_intStart;

	private bool f_blnFound;

	internal DataRow f_oDrwReturn;

	private DataTable f_oTblDM;

	protected internal virtual Button cmdEdit
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdEdit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmdEdit = value;
		}
	}

	protected internal virtual Button cmdAdd
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmdAdd = value;
		}
	}

	internal virtual TextBox txtCode_search
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCode_search;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = txtCode_search_TextChanged;
			KeyEventHandler val = new KeyEventHandler(txtCodeSearch_KeyDown);
			if (_txtCode_search != null)
			{
				((Control)_txtCode_search).TextChanged -= eventHandler;
				((Control)_txtCode_search).KeyDown -= val;
			}
			_txtCode_search = value;
			if (_txtCode_search != null)
			{
				((Control)_txtCode_search).TextChanged += eventHandler;
				((Control)_txtCode_search).KeyDown += val;
			}
		}
	}

	internal virtual TextBox txtSearch
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = txtSearch_TextChanged;
			KeyEventHandler val = new KeyEventHandler(txtSearch_KeyDown);
			if (_txtSearch != null)
			{
				((Control)_txtSearch).TextChanged -= eventHandler;
				((Control)_txtSearch).KeyDown -= val;
			}
			_txtSearch = value;
			if (_txtSearch != null)
			{
				((Control)_txtSearch).TextChanged += eventHandler;
				((Control)_txtSearch).KeyDown += val;
			}
		}
	}

	internal virtual Button cmdOK
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOK_Click;
			if (_cmdOK != null)
			{
				((Control)_cmdOK).Click -= eventHandler;
			}
			_cmdOK = value;
			if (_cmdOK != null)
			{
				((Control)_cmdOK).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn adgvcID
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvcID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvcID = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn adgvcBugNumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvcBugNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvcBugNumber = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn adgvcDescription
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvcDescription;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvcDescription = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn adgvcNote
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvcNote;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvcNote = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn adgvcLinkNumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvcLinkNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvcLinkNumber = value;
		}
	}

	protected virtual AsDataGridView adgvDM
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvDM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvDM = value;
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

	public frmLookup(DataTable oTblDM, string strCodeValue)
	{
		((Form)this).Load += frmLookup_Load;
		__ENCAddToList(this);
		f_intStart = 0;
		f_blnFound = false;
		InitializeComponent();
		f_oTblDM = oTblDM;
		f_strCodeValue = strCodeValue;
	}

	public frmLookup(string ID, string ProductID, string strCodeValue)
	{
		((Form)this).Load += frmLookup_Load;
		__ENCAddToList(this);
		f_intStart = 0;
		f_blnFound = false;
		InitializeComponent();
		f_strCodeValue = strCodeValue;
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		cmdEdit = new Button();
		cmdAdd = new Button();
		adgvDM = new AsDataGridView();
		adgvcID = new DataGridViewTextBoxColumn();
		adgvcBugNumber = new DataGridViewTextBoxColumn();
		adgvcDescription = new DataGridViewTextBoxColumn();
		adgvcNote = new DataGridViewTextBoxColumn();
		adgvcLinkNumber = new DataGridViewTextBoxColumn();
		txtCode_search = new TextBox();
		txtSearch = new TextBox();
		cmdOK = new Button();
		((ISupportInitialize)adgvDM).BeginInit();
		((Control)this).SuspendLayout();
		((Control)cmdEdit).Anchor = (AnchorStyles)10;
		((Control)cmdEdit).Enabled = false;
		((ButtonBase)cmdEdit).FlatStyle = (FlatStyle)1;
		((ButtonBase)cmdEdit).Image = (Image)(object)Resources.imgEdit;
		((ButtonBase)cmdEdit).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdEdit).ImeMode = (ImeMode)0;
		Button obj = cmdEdit;
		Point location = new Point(607, 431);
		((Control)obj).Location = location;
		((Control)cmdEdit).Name = "cmdEdit";
		((Control)cmdEdit).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdEdit;
		Size size = new Size(73, 23);
		((Control)obj2).Size = size;
		((Control)cmdEdit).TabIndex = 5;
		((ButtonBase)cmdEdit).Text = "&Sửa";
		((ButtonBase)cmdEdit).TextAlign = (ContentAlignment)64;
		((Control)cmdAdd).Anchor = (AnchorStyles)10;
		((Control)cmdAdd).Enabled = false;
		((ButtonBase)cmdAdd).FlatStyle = (FlatStyle)1;
		((ButtonBase)cmdAdd).Image = (Image)(object)Resources.imgAdd;
		((ButtonBase)cmdAdd).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdAdd).ImeMode = (ImeMode)0;
		Button obj3 = cmdAdd;
		location = new Point(528, 431);
		((Control)obj3).Location = location;
		((Control)cmdAdd).Name = "cmdAdd";
		((Control)cmdAdd).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdAdd;
		size = new Size(73, 23);
		((Control)obj4).Size = size;
		((Control)cmdAdd).TabIndex = 4;
		((ButtonBase)cmdAdd).Text = "&Mới";
		((ButtonBase)cmdAdd).TextAlign = (ContentAlignment)64;
		((DataGridView)adgvDM).AllowUserToAddRows = false;
		((DataGridView)adgvDM).AllowUserToDeleteRows = false;
		((DataGridView)adgvDM).AllowUserToOrderColumns = true;
		((Control)adgvDM).Anchor = (AnchorStyles)15;
		((DataGridView)adgvDM).BorderStyle = (BorderStyle)2;
		((DataGridView)adgvDM).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)adgvcID,
			(DataGridViewColumn)adgvcBugNumber,
			(DataGridViewColumn)adgvcDescription,
			(DataGridViewColumn)adgvcNote,
			(DataGridViewColumn)adgvcLinkNumber
		});
		adgvDM.DoubleBuffered = false;
		((DataGridView)adgvDM).EditMode = (DataGridViewEditMode)0;
		adgvDM.EnterKeyAsTabKey = false;
		((DataGridView)adgvDM).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = adgvDM;
		location = new Point(12, 12);
		((Control)asDataGridView).Location = location;
		((Control)adgvDM).Name = "adgvDM";
		adgvDM.ReadOnly = true;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvDM).RowHeadersDefaultCellStyle = val;
		adgvDM.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)adgvDM).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = adgvDM;
		size = new Size(668, 413);
		((Control)asDataGridView2).Size = size;
		((DataGridView)adgvDM).StandardTab = true;
		((Control)adgvDM).TabIndex = 0;
		((DataGridViewColumn)adgvcID).DataPropertyName = "ID";
		((DataGridViewColumn)adgvcID).HeaderText = "ID";
		((DataGridViewColumn)adgvcID).Name = "adgvcID";
		((DataGridViewColumn)adgvcID).Width = 80;
		((DataGridViewColumn)adgvcBugNumber).DataPropertyName = "BUGNUMBER";
		((DataGridViewColumn)adgvcBugNumber).HeaderText = "BugNumber";
		((DataGridViewColumn)adgvcBugNumber).Name = "adgvcBugNumber";
		((DataGridViewColumn)adgvcBugNumber).Width = 80;
		((DataGridViewColumn)adgvcDescription).DataPropertyName = "DESCRIPTION";
		((DataGridViewColumn)adgvcDescription).HeaderText = "Description";
		((DataGridViewColumn)adgvcDescription).Name = "adgvcDescription";
		((DataGridViewColumn)adgvcDescription).Width = 200;
		((DataGridViewColumn)adgvcNote).DataPropertyName = "NOTE";
		((DataGridViewColumn)adgvcNote).HeaderText = "Note";
		((DataGridViewColumn)adgvcNote).Name = "adgvcNote";
		((DataGridViewColumn)adgvcNote).Width = 150;
		((DataGridViewColumn)adgvcLinkNumber).DataPropertyName = "LINKNUMBER";
		((DataGridViewColumn)adgvcLinkNumber).HeaderText = "Link number";
		((DataGridViewColumn)adgvcLinkNumber).Name = "adgvcLinkNumber";
		((DataGridViewColumn)adgvcLinkNumber).Width = 80;
		((Control)txtCode_search).Anchor = (AnchorStyles)6;
		txtCode_search.CharacterCasing = (CharacterCasing)1;
		TextBox obj5 = txtCode_search;
		location = new Point(12, 434);
		((Control)obj5).Location = location;
		((TextBoxBase)txtCode_search).MaxLength = 20;
		((Control)txtCode_search).Name = "txtCode_search";
		TextBox obj6 = txtCode_search;
		size = new Size(114, 20);
		((Control)obj6).Size = size;
		((Control)txtCode_search).TabIndex = 1;
		((Control)txtSearch).Anchor = (AnchorStyles)6;
		TextBox obj7 = txtSearch;
		location = new Point(132, 434);
		((Control)obj7).Location = location;
		((TextBoxBase)txtSearch).MaxLength = 100;
		((Control)txtSearch).Name = "txtSearch";
		TextBox obj8 = txtSearch;
		size = new Size(191, 20);
		((Control)obj8).Size = size;
		((Control)txtSearch).TabIndex = 2;
		((Control)cmdOK).Anchor = (AnchorStyles)6;
		cmdOK.DialogResult = (DialogResult)1;
		((ButtonBase)cmdOK).FlatStyle = (FlatStyle)1;
		((ButtonBase)cmdOK).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdOK).ImeMode = (ImeMode)0;
		Button obj9 = cmdOK;
		location = new Point(329, 431);
		((Control)obj9).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		Button obj10 = cmdOK;
		size = new Size(73, 23);
		((Control)obj10).Size = size;
		((Control)cmdOK).TabIndex = 3;
		((ButtonBase)cmdOK).Text = "&Chọn";
		((ButtonBase)cmdOK).TextAlign = (ContentAlignment)64;
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOK;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(692, 466);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Control)this).Controls.Add((Control)(object)txtCode_search);
		((Control)this).Controls.Add((Control)(object)txtSearch);
		((Control)this).Controls.Add((Control)(object)adgvDM);
		((Control)this).Controls.Add((Control)(object)cmdEdit);
		((Control)this).Controls.Add((Control)(object)cmdAdd);
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		((Control)this).Name = "frmLookup";
		((Form)this).ShowInTaskbar = false;
		((Form)this).Text = "Danh sách cập nhật";
		((ISupportInitialize)adgvDM).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmLookup_Load(object sender, EventArgs e)
	{
		((DataGridView)adgvDM).DataSource = f_oTblDM.DefaultView;
		Sub_Search(Tim_Ma: true, f_strCodeValue);
		((Control)txtCode_search).Focus();
		((Control)txtCode_search).Select();
	}

	private void Sub_Search(bool Tim_Ma, string Gia_tri)
	{
		if (!Tim_Ma & !((Control)txtSearch).Enabled)
		{
			return;
		}
		DataRow[] array = null;
		string text = ((!Tim_Ma) ? "Description like '%" : "Convert(ID, 'System.String') like '%");
		text = text + Helper.Repl_Str(Gia_tri) + "%'";
		try
		{
			array = f_oTblDM.Select(text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			ProjectData.ClearProjectError();
		}
		if (array == null || array.Length <= 0 || 1 == 0)
		{
			return;
		}
		int num = f_intStart;
		checked
		{
			int num2 = f_oTblDM.DefaultView.Count - 1;
			int num3 = num;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				if (Array.IndexOf(array, f_oTblDM.DefaultView[num3].Row) != -1)
				{
					((DataGridView)adgvDM).CurrentCell = ((DataGridView)adgvDM).Rows[num3].Cells[((DataGridViewColumn)adgvcID).Name];
					f_intStart = num3 + 1;
					if (f_intStart == f_oTblDM.DefaultView.Count)
					{
						f_intStart = 0;
					}
					f_blnFound = true;
					return;
				}
				num3++;
			}
			f_intStart = 0;
			f_blnFound = false;
		}
	}

	private void MoveTo()
	{
		DataRow[] array = null;
		DataRow[] array2 = null;
		int num = -1;
		array2 = f_oTblDM.Select();
		try
		{
			array = f_oTblDM.Select("ID LIKE '" + f_strCodeValue.Trim() + "%'", "Ma");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			ProjectData.ClearProjectError();
		}
		if ((array != null && array.Length > 0) ? true : false)
		{
			try
			{
				num = Array.IndexOf(array2, array[0]);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			if ((num >= 0) & (num <= f_oTblDM.DefaultView.Count))
			{
				((DataGridView)adgvDM).Rows[num].Selected = true;
			}
		}
	}

	private void txtSearch_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		if (((int)e.KeyCode == 13) & (txtSearch.Text != null))
		{
			FilterDM(Tim_ma: false, txtSearch.Text.Trim());
		}
		if (((int)e.KeyCode == 40) | ((int)e.KeyCode == 38))
		{
			((Control)adgvDM).Focus();
		}
	}

	private void txtSearch_TextChanged(object sender, EventArgs e)
	{
		Filter();
	}

	private void txtCodeSearch_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		if (((int)e.KeyCode == 13) & (txtCode_search.Text != null))
		{
			FilterDM(Tim_ma: true, txtCode_search.Text.Trim());
		}
		if (((int)e.KeyCode == 40) | ((int)e.KeyCode == 38))
		{
			((Control)adgvDM).Focus();
		}
	}

	private void txtCode_search_TextChanged(object sender, EventArgs e)
	{
		Filter();
	}

	private void Filter()
	{
		f_intStart = 0;
		string text = "";
		if (txtCode_search.Text != null)
		{
			text = text + " Convert(ID, 'System.String') like '%" + txtCode_search.Text.Trim().Replace("%", "[%]").Replace("*", "[*]")
				.Replace("'", "''") + "%' And";
		}
		if ((txtSearch.Text != null && ((Control)txtSearch).Enabled) ? true : false)
		{
			text = text + " Description like '%" + txtSearch.Text.Trim().Replace("%", "[%]").Replace("*", "[*]")
				.Replace("'", "''") + "%'";
		}
		try
		{
			f_oTblDM.DefaultView.RowFilter = text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void FilterDM(bool Tim_ma, string Gia_tri)
	{
		Sub_Search(Tim_ma, Gia_tri);
		if (!f_blnFound)
		{
			Sub_Search(Tim_ma, Gia_tri);
		}
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		try
		{
			if ((((DataGridView)adgvDM).CurrentRow != null && f_oTblDM.DefaultView.Count > 0) ? true : false)
			{
				f_oDrwReturn = f_oTblDM.DefaultView[((DataGridViewBand)((DataGridView)adgvDM).CurrentRow).Index].Row;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			f_oDrwReturn = null;
			ProjectData.ClearProjectError();
		}
	}

	private void dg_DoubleClick(object sender, EventArgs e)
	{
	}

	protected override bool ProcessKeyPreview(ref Message m)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		Keys val = (Keys)(((Message)(ref m)).WParam.ToInt32() & 0xFFFF);
		if (((Message)(ref m)).Msg == 256)
		{
			if ((int)val == 27)
			{
				((Form)this).Close();
				return false;
			}
			if ((int)val == 13)
			{
				((Form)this).AcceptButton.PerformClick();
			}
		}
		return base.ProcessKeyPreview(ref m);
	}
}
