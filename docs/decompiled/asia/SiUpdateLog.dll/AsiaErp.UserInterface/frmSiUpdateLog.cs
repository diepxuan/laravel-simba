using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using AsiaErp.Compress;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using AsiaErp.ToolCommon;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using My.Resources;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSiUpdateLog : frmDMView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("splPanel")]
	private SplitContainer _splPanel;

	[AccessedThroughProperty("dgvDetail")]
	private AsDataGridView _dgvDetail;

	[AccessedThroughProperty("cmdZip")]
	private Button _cmdZip;

	[AccessedThroughProperty("DgSaveFile")]
	private SaveFileDialog _DgSaveFile;

	[AccessedThroughProperty("dgvcChon")]
	private DataGridViewCheckBoxColumn _dgvcChon;

	[AccessedThroughProperty("dgvcName")]
	private DataGridViewTextBoxColumn _dgvcName;

	[AccessedThroughProperty("dgvcTypeName")]
	private DataGridViewTextBoxColumn _dgvcTypeName;

	[AccessedThroughProperty("dgvcLast_Modify")]
	private DataGridViewAsMaskedTextBoxColumn _dgvcLast_Modify;

	[AccessedThroughProperty("dgvcFullPath")]
	private DataGridViewTextBoxColumn _dgvcFullPath;

	[AccessedThroughProperty("cmdHistory")]
	private Button _cmdHistory;

	[AccessedThroughProperty("lblUnzip")]
	private Label _lblUnzip;

	private int CurrentID;

	private DataTable f_dtDetail;

	private const string strFunctionFilter = "TYPE IN (N'FN', N'IF', N'TF', N'FS', N'FT')";

	private const string strStoredProcedureFilter = "TYPE IN (N'P', N'PC')";

	protected internal override BindingSource bsDanhMuc
	{
		[DebuggerNonUserCode]
		get
		{
			return base.bsDanhMuc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bsDanhMuc_PositionChanged;
			if (base.bsDanhMuc != null)
			{
				base.bsDanhMuc.PositionChanged -= eventHandler;
			}
			base.bsDanhMuc = value;
			if (base.bsDanhMuc != null)
			{
				base.bsDanhMuc.PositionChanged += eventHandler;
			}
		}
	}

	internal virtual SplitContainer splPanel
	{
		[DebuggerNonUserCode]
		get
		{
			return _splPanel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_splPanel = value;
		}
	}

	internal virtual AsDataGridView dgvDetail
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvDetail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(dgvDetail_CellClick);
			if (_dgvDetail != null)
			{
				((DataGridView)_dgvDetail).CellClick -= val;
			}
			_dgvDetail = value;
			if (_dgvDetail != null)
			{
				((DataGridView)_dgvDetail).CellClick += val;
			}
		}
	}

	internal virtual Button cmdZip
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdZip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdZip_Click;
			if (_cmdZip != null)
			{
				((Control)_cmdZip).Click -= eventHandler;
			}
			_cmdZip = value;
			if (_cmdZip != null)
			{
				((Control)_cmdZip).Click += eventHandler;
			}
		}
	}

	internal virtual SaveFileDialog DgSaveFile
	{
		[DebuggerNonUserCode]
		get
		{
			return _DgSaveFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DgSaveFile = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcChon
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcChon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcChon = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcName
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcName = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTypeName
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTypeName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTypeName = value;
		}
	}

	internal virtual DataGridViewAsMaskedTextBoxColumn dgvcLast_Modify
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcLast_Modify;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcLast_Modify = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcFullPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcFullPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcFullPath = value;
		}
	}

	internal virtual Button cmdHistory
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdHistory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdHistory_Click;
			if (_cmdHistory != null)
			{
				((Control)_cmdHistory).Click -= eventHandler;
			}
			_cmdHistory = value;
			if (_cmdHistory != null)
			{
				((Control)_cmdHistory).Click += eventHandler;
			}
		}
	}

	internal virtual Label lblUnzip
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblUnzip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblUnzip = value;
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

	public frmSiUpdateLog(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		InitializeComponent();
		((Control)cmdDel).Visible = false;
		((Control)cmdChgCode).Visible = false;
		((Control)cmdPrint).Visible = false;
		((Control)cmdAdd).Location = ((Control)cmdDel).Location;
		((Control)cmdEdit).Location = ((Control)cmdChgCode).Location;
		((Control)cmdHistory).Location = ((Control)cmdPrint).Location;
		Button obj = cmdZip;
		Point location = new Point(((Control)cmdZip).Location.X, ((Control)cmdPrint).Location.Y);
		((Control)obj).Location = location;
		((Control)splPanel.Panel1).Controls.Add((Control)(object)dgvDM);
		((Control)dgvDM).Dock = (DockStyle)5;
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected O, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSiUpdateLog));
		splPanel = new SplitContainer();
		dgvDetail = new AsDataGridView();
		dgvcChon = new DataGridViewCheckBoxColumn();
		dgvcName = new DataGridViewTextBoxColumn();
		dgvcTypeName = new DataGridViewTextBoxColumn();
		dgvcLast_Modify = new DataGridViewAsMaskedTextBoxColumn();
		dgvcFullPath = new DataGridViewTextBoxColumn();
		cmdZip = new Button();
		DgSaveFile = new SaveFileDialog();
		cmdHistory = new Button();
		lblUnzip = new Label();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)splPanel.Panel2).SuspendLayout();
		((Control)splPanel).SuspendLayout();
		((ISupportInitialize)dgvDetail).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = cmdChgCode;
		Point location = new Point(593, 424);
		((Control)obj).Location = location;
		TextBox obj2 = txtValue;
		location = new Point(-100, -72);
		((Control)obj2).Location = location;
		((Control)txtValue).Visible = false;
		Button obj3 = cmdDel;
		location = new Point(523, 424);
		((Control)obj3).Location = location;
		cboFilter.ItemHeight = 14;
		ComboBox obj4 = cboFilter;
		location = new Point(-100, -72);
		((Control)obj4).Location = location;
		ComboBox obj5 = cboFilter;
		Size size = new Size(77, 22);
		((Control)obj5).Size = size;
		((Control)cboFilter).Visible = false;
		Button obj6 = cmdEdit;
		location = new Point(453, 424);
		((Control)obj6).Location = location;
		Button obj7 = cmdSearch;
		location = new Point(-100, -72);
		((Control)obj7).Location = location;
		Button obj8 = cmdSearch;
		size = new Size(64, 27);
		((Control)obj8).Size = size;
		((Control)cmdSearch).Visible = false;
		Button obj9 = cmdAdd;
		location = new Point(383, 424);
		((Control)obj9).Location = location;
		Label obj10 = lblTen;
		location = new Point(-100, -72);
		((Control)obj10).Location = location;
		Label obj11 = lblTen;
		size = new Size(45, 19);
		((Control)obj11).Size = size;
		((Control)lblTen).Visible = false;
		Button obj12 = cmdPrint;
		location = new Point(663, 424);
		((Control)obj12).Location = location;
		Button obj13 = cmdClose;
		location = new Point(732, 424);
		((Control)obj13).Location = location;
		((Control)splPanel).Anchor = (AnchorStyles)15;
		SplitContainer obj14 = splPanel;
		location = new Point(9, 9);
		((Control)obj14).Location = location;
		((Control)splPanel).Name = "splPanel";
		splPanel.Orientation = (Orientation)0;
		((Control)splPanel.Panel2).Controls.Add((Control)(object)dgvDetail);
		SplitContainer obj15 = splPanel;
		size = new Size(788, 411);
		((Control)obj15).Size = size;
		splPanel.SplitterDistance = 189;
		((Control)splPanel).TabIndex = 41;
		((DataGridView)dgvDetail).AllowUserToAddRows = false;
		((DataGridView)dgvDetail).AllowUserToDeleteRows = false;
		((DataGridView)dgvDetail).BackgroundColor = Color.White;
		((DataGridView)dgvDetail).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvDetail).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)dgvcChon,
			(DataGridViewColumn)dgvcName,
			(DataGridViewColumn)dgvcTypeName,
			dgvcLast_Modify,
			(DataGridViewColumn)dgvcFullPath
		});
		((Control)dgvDetail).Dock = (DockStyle)5;
		dgvDetail.DoubleBuffered = false;
		((DataGridView)dgvDetail).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvDetail).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvDetail;
		location = new Point(0, 0);
		((Control)asDataGridView).Location = location;
		((Control)dgvDetail).Name = "dgvDetail";
		dgvDetail.ReadOnly = true;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvDetail).RowHeadersDefaultCellStyle = val;
		dgvDetail.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvDetail).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvDetail;
		size = new Size(788, 218);
		((Control)asDataGridView2).Size = size;
		((Control)dgvDetail).TabIndex = 1;
		((DataGridViewColumn)dgvcChon).DataPropertyName = "Chon";
		((DataGridViewColumn)dgvcChon).HeaderText = "Choose";
		((DataGridViewColumn)dgvcChon).Name = "dgvcChon";
		((DataGridViewColumn)dgvcChon).Width = 50;
		((DataGridViewColumn)dgvcName).DataPropertyName = "Name";
		((DataGridViewColumn)dgvcName).HeaderText = "Name";
		((DataGridViewColumn)dgvcName).Name = "dgvcName";
		((DataGridViewColumn)dgvcName).ReadOnly = true;
		((DataGridViewColumn)dgvcName).Width = 150;
		((DataGridViewColumn)dgvcTypeName).DataPropertyName = "TypeName";
		((DataGridViewColumn)dgvcTypeName).HeaderText = "Type";
		((DataGridViewColumn)dgvcTypeName).Name = "dgvcTypeName";
		((DataGridViewColumn)dgvcTypeName).ReadOnly = true;
		((DataGridViewColumn)dgvcTypeName).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcLast_Modify).DataPropertyName = "Last_Modify";
		val2.Alignment = (DataGridViewContentAlignment)64;
		val2.Format = "dd/MM/yyyy";
		((DataGridViewColumn)dgvcLast_Modify).DefaultCellStyle = val2;
		dgvcLast_Modify.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)dgvcLast_Modify).HeaderText = "Last_Modify";
		dgvcLast_Modify.Mask = "##/##/####";
		((DataGridViewColumn)dgvcLast_Modify).Name = "dgvcLast_Modify";
		((DataGridViewColumn)dgvcLast_Modify).ReadOnly = true;
		((DataGridViewColumn)dgvcLast_Modify).Resizable = (DataGridViewTriState)1;
		dgvcLast_Modify.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcLast_Modify).Width = 75;
		((DataGridViewColumn)dgvcFullPath).AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
		((DataGridViewColumn)dgvcFullPath).DataPropertyName = "FullPath";
		((DataGridViewColumn)dgvcFullPath).HeaderText = "FullPath";
		((DataGridViewColumn)dgvcFullPath).Name = "dgvcFullPath";
		((Control)cmdZip).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdZip).Image = (Image)componentResourceManager.GetObject("cmdZip.Image");
		((ButtonBase)cmdZip).ImageAlign = (ContentAlignment)16;
		Button obj16 = cmdZip;
		location = new Point(12, 424);
		((Control)obj16).Location = location;
		((Control)cmdZip).Name = "cmdZip";
		Button obj17 = cmdZip;
		size = new Size(75, 25);
		((Control)obj17).Size = size;
		((Control)cmdZip).TabIndex = 42;
		((ButtonBase)cmdZip).Text = "&Tạo File";
		((ButtonBase)cmdZip).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdZip).UseVisualStyleBackColor = true;
		((FileDialog)DgSaveFile).Filter = "Zip File|*.zip";
		((Control)cmdHistory).Anchor = (AnchorStyles)10;
		((ButtonBase)cmdHistory).Image = (Image)(object)Resources.imgHistory;
		((ButtonBase)cmdHistory).ImageAlign = (ContentAlignment)16;
		Button obj18 = cmdHistory;
		location = new Point(663, 424);
		((Control)obj18).Location = location;
		((Control)cmdHistory).Name = "cmdHistory";
		Button obj19 = cmdHistory;
		size = new Size(64, 25);
		((Control)obj19).Size = size;
		((Control)cmdHistory).TabIndex = 31;
		((ButtonBase)cmdHistory).Text = "&History";
		((ButtonBase)cmdHistory).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdHistory).UseVisualStyleBackColor = true;
		((Control)lblUnzip).Anchor = (AnchorStyles)6;
		lblUnzip.AutoSize = true;
		Label obj20 = lblUnzip;
		location = new Point(92, 429);
		((Control)obj20).Location = location;
		((Control)lblUnzip).Name = "lblUnzip";
		Label obj21 = lblUnzip;
		size = new Size(122, 14);
		((Control)obj21).Size = size;
		((Control)lblUnzip).TabIndex = 43;
		lblUnzip.Text = "(Alt + Shift + Z to unzip)";
		SizeF autoScaleDimensions = new SizeF(6f, 14f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(806, 457);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)lblUnzip);
		((Control)this).Controls.Add((Control)(object)cmdHistory);
		((Control)this).Controls.Add((Control)(object)cmdZip);
		((Control)this).Controls.Add((Control)(object)splPanel);
		((Control)this).Font = new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		((Control)this).Name = "frmSiUpdateLog";
		((Form)this).Text = "frmSiUpdateLog";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdClose, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblTen, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cboFilter, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDel, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtValue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdChgCode, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)splPanel, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdZip, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdHistory, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblUnzip, 0);
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)splPanel.Panel2).ResumeLayout(false);
		((Control)splPanel).ResumeLayout(false);
		((ISupportInitialize)dgvDetail).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherAfterLoadData()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		base.InitOtherAfterLoadData();
		GetDataDetail();
		((DataGridView)dgvDM).CellClick += new DataGridViewCellEventHandler(dgvDM_CellClick);
	}

	protected override void SetPrimaryKeyAndDefaultValue()
	{
		base.SetPrimaryKeyAndDefaultValue();
		SourceTable.Columns["ID"].DefaultValue = 0;
		SourceTable.Columns["chon"].DefaultValue = 0;
	}

	protected override void AddNew()
	{
		base.AddNew();
		ReloadData();
		Refesh();
	}

	protected override void Edit()
	{
		base.Edit();
		ReloadData();
		Refesh();
	}

	protected override void Delete()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		if ((bsDanhMuc.Current != null && (int)CMessageBox.Show(50003, SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxDefaultButton)256) != 7) ? true : false)
		{
			DataRowView dataRowView = (DataRowView)bsDanhMuc.Current;
			if (MyController.Delete(dataRowView.Row))
			{
				DataRow[] array = f_dtDetail.Select("ID=" + dataRowView["ID"].ToString());
				foreach (DataRow dataRow in array)
				{
					dataRow.Delete();
				}
				f_dtDetail.AcceptChanges();
				dataRowView.Delete();
				SourceTable.AcceptChanges();
			}
		}
		Refesh();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 116)
		{
			cmdHistory_Click(null, null);
		}
		if ((int)keyData == 119)
		{
			Delete();
		}
		if ((int)keyData == 327770)
		{
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).Filter = "Asia compress File|*.zip";
			((CommonDialog)val).ShowDialog();
			if (!string.IsNullOrEmpty(((FileDialog)val).FileName))
			{
				AsiaCompress val2 = AsiaCompress.Open(((FileDialog)val).FileName, FileAccess.Read);
				List<ZipFileEntry> list = val2.ReadCentralDir();
				string text = Path.Combine(Path.GetDirectoryName(((FileDialog)val).FileName), Path.GetFileNameWithoutExtension(((FileDialog)val).FileName));
				if (Directory.Exists(text))
				{
					Directory.Delete(text, recursive: true);
				}
				foreach (ZipFileEntry item in list)
				{
					string text2 = Path.Combine(text, item.FilenameInZip);
					bool flag = val2.ExtractFile(item, text2);
				}
				val2.Close();
				CMessageBox.Show(50015);
				GC.Collect();
				GC.WaitForPendingFinalizers();
			}
		}
		return base.ProcessCmdKey(ref msg, keyData);
	}

	private void bsDanhMuc_PositionChanged(object sender, EventArgs e)
	{
		if (!f_blnIsLoading)
		{
			Refesh();
		}
	}

	private void cmdZip_Click(object sender, EventArgs e)
	{
		GenFilesToZip();
	}

	private void dgvDM_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if ((((DataGridView)dgvDM).DataSource != null && e.ColumnIndex == 0) ? true : false)
		{
			((DataGridView)dgvDM).CurrentCell.Value = Operators.NotObject(((DataGridView)dgvDM).CurrentCell.Value);
			DataRow[] array = f_dtDetail.Select("id=" + NewLateBinding.LateIndexGet(((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvDM).DataSource)].Current, new object[1] { "ID" }, (string[])null).ToString());
			foreach (DataRow dataRow in array)
			{
				dataRow["chon"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvDM).CurrentCell.Value);
			}
			f_dtDetail.AcceptChanges();
		}
	}

	private void dgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if ((((DataGridView)dgvDetail).DataSource != null && e.ColumnIndex == 0) ? true : false)
		{
			((DataGridView)dgvDetail).CurrentCell.Value = Operators.NotObject(((DataGridView)dgvDetail).CurrentCell.Value);
		}
	}

	private void cmdHistory_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		frmHistory frmHistory2 = new frmHistory(CurrentID);
		((Form)frmHistory2).ShowDialog((IWin32Window)(object)this);
	}

	private void ReloadData()
	{
		base.GetData();
		base.DataBinding();
		Refresh();
	}

	private void Refesh()
	{
		if (SourceTable.Rows.Count > 0)
		{
			CurrentID = Conversions.ToInteger(((DataRowView)bsDanhMuc.Current)["ID"]);
			bool flag = Conversions.ToBoolean(((DataRowView)bsDanhMuc.Current)["Chon"]);
			f_dtDetail.DefaultView.RowFilter = "ID=" + Conversions.ToString(CurrentID);
			DataRow[] array = f_dtDetail.Select("ID=" + Conversions.ToString(CurrentID));
			foreach (DataRow dataRow in array)
			{
				dataRow["chon"] = flag;
			}
		}
	}

	private void GetDataDetail()
	{
		SIUpdateLogDAO sIUpdateLogDAO = (SIUpdateLogDAO)DAOFactory.CreateDAOInstance("SIUpdateLogDAO", "SIUpdateLog");
		f_dtDetail = sIUpdateLogDAO.GetDataDetail();
		sIUpdateLogDAO.Destroy();
		f_dtDetail.Columns["ID"].DefaultValue = 0;
		DataColumn dataColumn = new DataColumn();
		dataColumn.ColumnName = "TypeName";
		dataColumn.Expression = "IIF(type=0,'File','DBOject')";
		f_dtDetail.Columns.Add(dataColumn);
		((DataGridView)dgvDetail).DataSource = f_dtDetail.DefaultView;
		frmSiUpdateLogEdit.f_dtDetail = f_dtDetail;
		Refesh();
	}

	private string GetConnectionById(int id)
	{
		string result = "";
		foreach (DataRow row in SourceTable.Rows)
		{
			if (Operators.ConditionalCompareObjectEqual(row["Id"], (object)id, false))
			{
				result = Conversions.ToString(row["Connection"]);
				break;
			}
		}
		return result;
	}

	private string ReplaceSpaceWhenEmpty(string pString)
	{
		if (Operators.CompareString(pString, "", false) != 0)
		{
			return pString;
		}
		return " ";
	}

	private void GenFileReadme(DataRow[] dtv)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		string path = Application.StartupPath + "\\Temp\\Readme.txt";
		Font arg = new Font("Times New Roman", 10f, (FontStyle)0);
		TextWriter textWriter = new StreamWriter(path, append: true, Encoding.UTF8);
		foreach (DataRow dataRow in dtv)
		{
			string format = new string('=', 100) + "\r\nID            " + ReplaceSpaceWhenEmpty(Conversions.ToString(dataRow["ID"])) + "\r\nBug number    " + ReplaceSpaceWhenEmpty(Conversions.ToString(dataRow["BugNumber"])) + "\r\nProduct       " + ReplaceSpaceWhenEmpty(Conversions.ToString(dataRow["ProductName"])) + "\r\nDescription   " + ReplaceSpaceWhenEmpty(Conversions.ToString(dataRow["Description"])) + "\r\nNote          " + ReplaceSpaceWhenEmpty(Conversions.ToString(dataRow["Note"])) + "\r\nCDate         " + ReplaceSpaceWhenEmpty(Conversions.ToString(dataRow["CDate"])) + "\r\nLDate         " + ReplaceSpaceWhenEmpty(Conversions.ToString(dataRow["LDate"])) + "\r\n" + new string('=', 100) + "\r\n";
			textWriter.WriteLine(format, arg);
		}
		textWriter.Close();
	}

	private void GenFilesToZip()
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		if ((bsDanhMuc.DataSource == null || f_dtDetail.DefaultView.Count <= 0 || SourceTable.Select("chon = 1").Count() <= 0) ? true : false)
		{
			CMessageBox.Show(50555);
			return;
		}
		DataRowView dataRowView = (DataRowView)bsDanhMuc.Current;
		string empty = string.Empty;
		((FileDialog)DgSaveFile).InitialDirectory = Application.StartupPath;
		((FileDialog)DgSaveFile).FileName = ((FileDialog)DgSaveFile).InitialDirectory + "\\AsiaUpdate" + DateTime.Now.ToString("yyyy/MM/dd").Replace("/", "");
		if ((int)((CommonDialog)DgSaveFile).ShowDialog() == 2)
		{
			return;
		}
		if (string.IsNullOrEmpty(((FileDialog)DgSaveFile).FileName))
		{
			CMessageBox.Show(50010);
			return;
		}
		string text = Application.StartupPath + "\\Temp";
		if (Directory.Exists(text))
		{
			Directory.Delete(text, recursive: true);
		}
		Directory.CreateDirectory(text);
		GenFileReadme(SourceTable.Select("chon=1"));
		IOrderedEnumerable<VB_0024AnonymousType_0<object, object, object, object>> orderedEnumerable = from object oDr in f_dtDetail.Rows
			select (DataRow)oDr into oDr
			where Conversions.ToBoolean((!Conversions.ToBoolean(Operators.CompareObjectEqual(oDr["type"], (object)1, false)) || !Conversions.ToBoolean(Operators.CompareObjectEqual(oDr["chon"], (object)true, false))) ? ((object)false) : ((object)true))
			select new VB_0024AnonymousType_0<object, object, object, object>(RuntimeHelpers.GetObjectValue(oDr["Item_id"]), RuntimeHelpers.GetObjectValue(oDr["Id"]), RuntimeHelpers.GetObjectValue(oDr["name"]), RuntimeHelpers.GetObjectValue(oDr["fullpath"])) into _0024VB_0024It
			orderby _0024VB_0024It.ItemID
			select _0024VB_0024It;
		int num = 1;
		checked
		{
			foreach (VB_0024AnonymousType_0<object, object, object, object> item in orderedEnumerable)
			{
				TCommon.set_Session((object)"sDataCnnString", (object)GetConnectionById(Conversions.ToInteger(item.ID)));
				DataTable dataTable = TCommon.TGetDataTableByQuerry(false, string.Format(Resources.TSQL_GetDefineObj, RuntimeHelpers.GetObjectValue(item.Name)));
				if (dataTable == null)
				{
					CMessageBox.Show(50010);
					return;
				}
				string text2 = item.Fullpath.ToString().Substring(item.Fullpath.ToString().IndexOf("\\") + 1);
				string text3 = text2.Substring(0, text2.IndexOf("\\")).ToLower();
				string text4 = "";
				switch (text3)
				{
				case "function":
					text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[", item.Name), (object)"]') AND "), (object)"TYPE IN (N'FN', N'IF', N'TF', N'FS', N'FT')"), (object)")"), (object)"\r\n"), (object)"DROP FUNCTION [dbo].["), item.Name), (object)"]"), (object)"\r\n"), (object)"GO"), (object)"\r\n"));
					break;
				case "stored procedure":
					text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[", item.Name), (object)"]') AND "), (object)"TYPE IN (N'P', N'PC')"), (object)")"), (object)"\r\n"), (object)"DROP PROCEDURE [dbo].["), item.Name), (object)"]"), (object)"\r\n"), (object)"GO"), (object)"\r\n"));
					break;
				case "view":
					text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"IF EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[", item.Name), (object)"]'))"), (object)"DROP VIEW [dbo].["), item.Name), (object)"]"), (object)"\r\n"), (object)"GO"), (object)"\r\n"));
					break;
				}
				string path = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(text + "\\", Strings.Right("000" + Conversions.ToString(num), 3)), "."), item.Name), (object)".sql"));
				num++;
				File.WriteAllText(path, Conversions.ToString(Operators.ConcatenateObject((object)text4, dataTable.Rows[0][0])), Encoding.Unicode);
			}
			AsiaCompress val = AsiaCompress.Create(((FileDialog)DgSaveFile).FileName, "Generated by AsiaCompress.", true);
			val.EncodeUTF8 = true;
			val.AddFile((Compression)8, Application.StartupPath + "\\Temp\\Readme.txt", "Readme.txt", "Vui lòng đọc tệp này để biết thông tin cập nhật.");
			foreach (string item2 in from str in Directory.GetFiles(text)
				where str.Contains(".sql")
				select str)
			{
				val.AddFile((Compression)8, item2, "\\TSQL\\" + Path.GetFileName(item2), "Tệp tin thủ tục SQL.");
			}
			IEnumerable<DataRow> enumerable = from object oDr in f_dtDetail.Rows
				select (DataRow)oDr into oDr
				where Conversions.ToBoolean((!Conversions.ToBoolean(Operators.CompareObjectEqual(oDr["type"], (object)0, false)) || !Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDr["chon"]), isNum: true), (object)true, false)) || !Conversions.ToBoolean((object)(Operators.CompareString(Strings.Right(Conversions.ToString(oDr["fullpath"]), 4).ToLower(), ".dll", false) == 0))) ? ((object)false) : ((object)true))
				select (oDr);
			foreach (DataRow item3 in enumerable)
			{
				File.SetAttributes(Conversions.ToString(item3["fullpath"]), FileAttributes.Archive);
				val.AddFile((Compression)8, Conversions.ToString(item3["fullpath"]), "\\_Dlls\\" + Path.GetFileName(Conversions.ToString(item3["fullpath"])), "Tệp tin thực thi chức năng.");
			}
			IEnumerable<DataRow> enumerable2 = from object oDr in f_dtDetail.Rows
				select (DataRow)oDr into oDr
				where Conversions.ToBoolean((!Conversions.ToBoolean(Operators.CompareObjectEqual(oDr["type"], (object)0, false)) || !Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDr["chon"]), isNum: true), (object)true, false)) || !Conversions.ToBoolean((object)(Operators.CompareString(Strings.Right(Conversions.ToString(oDr["fullpath"]), 4).ToLower(), ".rpt", false) == 0)) || !Conversions.ToBoolean((object)(!oDr["fullpath"].ToString().ToLower().Contains("\\reports\\nt\\")))) ? ((object)false) : ((object)true))
				select (oDr);
			foreach (DataRow item4 in enumerable2)
			{
				File.SetAttributes(Conversions.ToString(item4["fullpath"]), FileAttributes.Archive);
				val.AddFile((Compression)8, Conversions.ToString(item4["fullpath"]), "\\Reports\\" + Path.GetFileName(Conversions.ToString(item4["fullpath"])), "Tệp tin báo cáo.");
			}
			IEnumerable<DataRow> enumerable3 = from object oDr in f_dtDetail.Rows
				select (DataRow)oDr into oDr
				where Conversions.ToBoolean((!Conversions.ToBoolean(Operators.CompareObjectEqual(oDr["type"], (object)0, false)) || !Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDr["chon"]), isNum: true), (object)true, false)) || !Conversions.ToBoolean((object)(Operators.CompareString(Strings.Right(Conversions.ToString(oDr["fullpath"]), 4).ToLower(), ".rpt", false) == 0)) || !Conversions.ToBoolean((object)oDr["fullpath"].ToString().ToLower().Contains("\\reports\\nt\\"))) ? ((object)false) : ((object)true))
				select (oDr);
			foreach (DataRow item5 in enumerable3)
			{
				File.SetAttributes(Conversions.ToString(item5["fullpath"]), FileAttributes.Archive);
				val.AddFile((Compression)8, Conversions.ToString(item5["fullpath"]), "\\Reports\\NT\\" + Path.GetFileName(Conversions.ToString(item5["fullpath"])), "Tệp tin báo cáo.");
			}
			val.Close();
			Directory.Delete(text, recursive: true);
			GC.Collect();
			GC.WaitForPendingFinalizers();
			CMessageBox.Show(50015);
		}
	}
}
