using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERp.UserInterface;

[DesignerGenerated]
public class frmFARptBCTS01 : frmReport2DGV
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_ts")]
	private AsTextBox _txtMa_ts;

	[AccessedThroughProperty("lblMa_ts")]
	private Label _lblMa_ts;

	[AccessedThroughProperty("lblTen_ts")]
	private Label _lblTen_ts;

	protected internal override AsDataGridView dgvBCPh
	{
		[DebuggerNonUserCode]
		get
		{
			return base.dgvBCPh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = dgvBCPh_CurrentCellChanged;
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(dgvBC_CellContentClick);
			if (base.dgvBCPh != null)
			{
				((DataGridView)base.dgvBCPh).CurrentCellChanged -= eventHandler;
				((DataGridView)base.dgvBCPh).CellContentClick -= val;
			}
			base.dgvBCPh = value;
			if (base.dgvBCPh != null)
			{
				((DataGridView)base.dgvBCPh).CurrentCellChanged += eventHandler;
				((DataGridView)base.dgvBCPh).CellContentClick += val;
			}
		}
	}

	internal virtual AsTextBox txtMa_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_ts = value;
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

	internal virtual Label lblTen_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_ts = value;
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

	public frmFARptBCTS01(string MenuID)
		: base(MenuID)
	{
		((Form)this).Load += frmFARptBCTS01_Load;
		__ENCAddToList(this);
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
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		txtMa_ts = new AsTextBox();
		lblTen_ts = new Label();
		lblMa_ts = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)tabGrid).SuspendLayout();
		((Control)scGrid).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(640, 248);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_ts);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_ts);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_ts);
		TabPage obj = tabFilter;
		size = new Size(632, 219);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_ts, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_ts, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_ts, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)lbl2).TabIndex = 10;
		((Control)lbl2).Visible = false;
		Button obj2 = cmdExcel;
		Point location = new Point(495, 1573);
		((Control)obj2).Location = location;
		((Control)cmdExcel).TabIndex = 6;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(110, 78);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj3 = cmdCancel;
		location = new Point(414, 1573);
		((Control)obj3).Location = location;
		((Control)cmdCancel).TabIndex = 5;
		((Control)cmdModifyReport).TabIndex = 8;
		((Control)cmdModifyReport).TabStop = true;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(397, 78);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		((Control)txtNgay1).Visible = false;
		ComboBox obj4 = cboKyBc;
		location = new Point(397, 109);
		((Control)obj4).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		((Control)cboKyBc).Visible = false;
		((Control)lblKyBc).TabIndex = 16;
		ComboBox obj5 = cboMau_bc;
		location = new Point(110, 24);
		((Control)obj5).Location = location;
		((Control)cboMau_bc).TabIndex = 7;
		((Control)lblMau_bc).TabIndex = 18;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(249, 424);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).Visible = false;
		Label obj6 = lblMauBC;
		location = new Point(110, 131);
		((Control)obj6).Location = location;
		((Control)lblMauBC).TabIndex = 12;
		RadioButton obj7 = optVND;
		location = new Point(206, 130);
		((Control)obj7).Location = location;
		((Control)optVND).TabIndex = 13;
		optVND.TabStop = false;
		RadioButton obj8 = optNt;
		location = new Point(260, 131);
		((Control)obj8).Location = location;
		((Control)optNt).TabIndex = 14;
		Label obj9 = lblMa_nt;
		location = new Point(163, 426);
		((Control)obj9).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj10 = cmdOk;
		location = new Point(27, 182);
		((Control)obj10).Location = location;
		((Control)cmdOk).TabIndex = 4;
		((Control)lblTieu_de).TabIndex = 17;
		((Control)txtTieu_De).TabIndex = 9;
		TabPage obj11 = tabGrid;
		size = new Size(602, 213);
		((Control)obj11).Size = size;
		SplitContainer obj12 = scGrid;
		size = new Size(596, 207);
		((Control)obj12).Size = size;
		scGrid.SplitterDistance = 139;
		txtMa_ts.AutoLookup = true;
		txtMa_ts.AutoValid = false;
		((TextBoxBase)txtMa_ts).BackColor = SystemColors.Info;
		((TextBox)txtMa_ts).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_ts;
		location = new Point(110, 105);
		((Control)asTextBox2).Location = location;
		txtMa_ts.LookupCodeName = "MA_TS";
		((Control)txtMa_ts).Name = "txtMa_ts";
		txtMa_ts.NameControl = lblTen_ts;
		AsTextBox asTextBox3 = txtMa_ts;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_ts).TabIndex = 3;
		((Control)txtMa_ts).Tag = "MA_TS";
		txtMa_ts.UseAutoCompleteSource = true;
		Label obj13 = lblTen_ts;
		location = new Point(206, 109);
		((Control)obj13).Location = location;
		((Control)lblTen_ts).Name = "lblTen_ts";
		Label obj14 = lblTen_ts;
		size = new Size(324, 13);
		((Control)obj14).Size = size;
		((Control)lblTen_ts).TabIndex = 11;
		lblMa_ts.AutoSize = true;
		Label obj15 = lblMa_ts;
		location = new Point(24, 109);
		((Control)obj15).Location = location;
		((Control)lblMa_ts).Name = "lblMa_ts";
		Label obj16 = lblMa_ts;
		size = new Size(39, 13);
		((Control)obj16).Size = size;
		((Control)lblMa_ts).TabIndex = 15;
		lblMa_ts.Text = "Mã TS";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(640, 273);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFARptBCTS01";
		Send2CrystalByConnection = true;
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)tabGrid).ResumeLayout(false);
		((Control)scGrid).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_ts).Text.Trim());
		arrayList.Add("");
		DataSet dataSet = base.MyController.GetDataSet(arrayList.ToArray());
		set_MyDGVPhSource(isSet2Print: false, dataSet.Tables[1]);
		set_MyDGVCtSource(isSet2Print: true, dataSet.Tables[0]);
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strSubTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (Operators.CompareString(((TextBox)txtMa_ts).Text.Trim(), "", false) != 0)
		{
			stringBuilder.Append(lblMa_ts.Text + ":" + ((TextBox)txtMa_ts).Text.Trim() + ";");
		}
		return stringBuilder.ToString();
	}

	private void dgvBC_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex != -1 && !base.IsLoading && 0 == 0 && e.ColumnIndex == ((DataGridViewBand)((DataGridView)dgvBCPh).Columns["colPHTAG"]).Index)
		{
			get_MyDGVPhSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBCPh).CurrentRow).Index]["TAG"] = Operators.NotObject(get_MyDGVPhSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBCPh).CurrentRow).Index]["TAG"]);
		}
	}

	private void dgvBCPh_CurrentCellChanged(object sender, EventArgs e)
	{
		if (base.IsLoading || ((DataGridView)dgvBCPh).CurrentCell == null)
		{
			return;
		}
		try
		{
			if (get_MyDGVCtSource(isSet2Print: true).Rows.Count > 0)
			{
				get_MyDGVCtSource(isSet2Print: true).DefaultView.RowFilter = Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"ma_ts= '", Helper.Repl_Null(RuntimeHelpers.GetObjectValue(get_MyDGVPhSource(isSet2Print: true).DefaultView[((DataGridViewBand)((DataGridView)dgvBCPh).CurrentRow).Index]["ma_ts"]), isNum: false)), (object)"'"));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void frmFARptBCTS01_Load(object sender, EventArgs e)
	{
		cboKyBc.SelectedIndex = checked(cboKyBc.Items.Count - 1);
	}

	protected override void ViewCrystalByConnection()
	{
		string text = "";
		DataRow[] array = get_MyDGVPhSource(isSet2Print: true).Select("tag=1");
		foreach (DataRow dataRow in array)
		{
			text = Conversions.ToString(Operators.AddObject((object)text, Operators.AddObject(Operators.AddObject((object)",", dataRow["ma_ts"]), (object)",")));
		}
		if (text.Length != 0)
		{
			base.Parameters4StoredProcedure.Clear();
			base.Parameters4StoredProcedure.Add("@pMa_cty", CompanyInformations.CompanyID);
			base.Parameters4StoredProcedure.Add("@pNgay", RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			base.Parameters4StoredProcedure.Add("@pMa_ts", "");
			base.Parameters4StoredProcedure.Add("@pMa_ts_all", text);
			base.ViewCrystalByConnection();
		}
	}
}
