using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmINTransferINCDVT : frmCalc
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblSure")]
	private Label _lblSure;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblFinal_day")]
	private Label _lblFinal_day;

	[AccessedThroughProperty("lblConfirm")]
	private Label _lblConfirm;

	[AccessedThroughProperty("lblMa_so")]
	private Label _lblMa_so;

	[AccessedThroughProperty("txtConfirm")]
	private TextBox _txtConfirm;

	[AccessedThroughProperty("txtMa_so")]
	private TextBox _txtMa_so;

	[AccessedThroughProperty("txtFinal_day")]
	private AsMaskedTextBox _txtFinal_day;

	[AccessedThroughProperty("bgWorker")]
	private BackgroundWorker _bgWorker;

	private bool bSuccess;

	internal virtual Label lblSure
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSure;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSure = value;
		}
	}

	internal virtual Label lblMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_kho = value;
		}
	}

	internal virtual Label lblTen_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kho = value;
		}
	}

	internal virtual AsTextBox txtMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_kho = value;
		}
	}

	internal virtual Label lblFinal_day
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFinal_day;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFinal_day = value;
		}
	}

	internal virtual Label lblConfirm
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblConfirm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblConfirm = value;
		}
	}

	internal virtual Label lblMa_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_so = value;
		}
	}

	internal virtual TextBox txtConfirm
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtConfirm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtConfirm_TextChanged;
			if (_txtConfirm != null)
			{
				((Control)_txtConfirm).TextChanged -= eventHandler;
			}
			_txtConfirm = value;
			if (_txtConfirm != null)
			{
				((Control)_txtConfirm).TextChanged += eventHandler;
			}
		}
	}

	internal virtual TextBox txtMa_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_so = value;
		}
	}

	internal virtual AsMaskedTextBox txtFinal_day
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFinal_day;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtFinal_day = value;
		}
	}

	internal virtual BackgroundWorker bgWorker
	{
		[DebuggerNonUserCode]
		get
		{
			return _bgWorker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			RunWorkerCompletedEventHandler value2 = bgWorker_RunWorkerCompleted;
			DoWorkEventHandler value3 = bgWorker_DoWork;
			if (_bgWorker != null)
			{
				_bgWorker.RunWorkerCompleted -= value2;
				_bgWorker.DoWork -= value3;
			}
			_bgWorker = value;
			if (_bgWorker != null)
			{
				_bgWorker.RunWorkerCompleted += value2;
				_bgWorker.DoWork += value3;
			}
		}
	}

	public frmINTransferINCDVT(string MenuID)
		: base(MenuID)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		bSuccess = false;
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
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
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		lblSure = new Label();
		lblFinal_day = new Label();
		txtMa_kho = new AsTextBox();
		lblTen_kho = new Label();
		lblMa_kho = new Label();
		lblMa_so = new Label();
		txtMa_so = new TextBox();
		txtConfirm = new TextBox();
		lblConfirm = new Label();
		txtFinal_day = new AsMaskedTextBox();
		bgWorker = new BackgroundWorker();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 153);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		((Control)gbInput).Controls.Add((Control)(object)txtFinal_day);
		((Control)gbInput).Controls.Add((Control)(object)lblConfirm);
		((Control)gbInput).Controls.Add((Control)(object)lblMa_so);
		((Control)gbInput).Controls.Add((Control)(object)lblMa_kho);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_kho);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_kho);
		((Control)gbInput).Controls.Add((Control)(object)txtConfirm);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_so);
		((Control)gbInput).Controls.Add((Control)(object)lblFinal_day);
		((Control)gbInput).Controls.Add((Control)(object)lblSure);
		GroupBox obj2 = gbInput;
		Size size = new Size(433, 138);
		((Control)obj2).Size = size;
		((Control)gbInput).TabIndex = 0;
		Button obj3 = cmdOK;
		location = new Point(12, 153);
		((Control)obj3).Location = location;
		((Control)cmdOK).TabIndex = 1;
		lblSure.AutoSize = true;
		((Control)lblSure).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblSure).ForeColor = Color.Red;
		Label obj4 = lblSure;
		location = new Point(113, 16);
		((Control)obj4).Location = location;
		((Control)lblSure).Name = "lblSure";
		Label obj5 = lblSure;
		size = new Size(215, 13);
		((Control)obj5).Size = size;
		((Control)lblSure).TabIndex = 0;
		lblSure.Text = "Bạn có chắc chuyển dữ liệu sang năm sau?";
		lblFinal_day.AutoSize = true;
		Label obj6 = lblFinal_day;
		location = new Point(21, 51);
		((Control)obj6).Location = location;
		((Control)lblFinal_day).Name = "lblFinal_day";
		Label obj7 = lblFinal_day;
		size = new Size(121, 13);
		((Control)obj7).Size = size;
		((Control)lblFinal_day).TabIndex = 1;
		lblFinal_day.Text = "Ngày cuối năm hiện thời";
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_kho;
		location = new Point(149, 74);
		((Control)asTextBox).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox2 = txtMa_kho;
		size = new Size(101, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_kho).TabIndex = 0;
		((Control)txtMa_kho).Tag = "MA_KHO";
		Label obj8 = lblTen_kho;
		location = new Point(256, 76);
		((Control)obj8).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj9 = lblTen_kho;
		size = new Size(162, 16);
		((Control)obj9).Size = size;
		((Control)lblTen_kho).TabIndex = 4;
		lblMa_kho.AutoSize = true;
		Label obj10 = lblMa_kho;
		location = new Point(21, 78);
		((Control)obj10).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj11 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_kho).TabIndex = 4;
		lblMa_kho.Text = "Mã kho";
		lblMa_so.AutoSize = true;
		Label obj12 = lblMa_so;
		location = new Point(21, 104);
		((Control)obj12).Location = location;
		((Control)lblMa_so).Name = "lblMa_so";
		Label obj13 = lblMa_so;
		size = new Size(36, 13);
		((Control)obj13).Size = size;
		((Control)lblMa_so).TabIndex = 5;
		lblMa_so.Text = "Mã số";
		TextBox obj14 = txtMa_so;
		location = new Point(149, 100);
		((Control)obj14).Location = location;
		((Control)txtMa_so).Name = "txtMa_so";
		((TextBoxBase)txtMa_so).ReadOnly = true;
		TextBox obj15 = txtMa_so;
		size = new Size(101, 20);
		((Control)obj15).Size = size;
		((Control)txtMa_so).TabIndex = 1;
		TextBox obj16 = txtConfirm;
		location = new Point(317, 100);
		((Control)obj16).Location = location;
		((Control)txtConfirm).Name = "txtConfirm";
		TextBox obj17 = txtConfirm;
		size = new Size(101, 20);
		((Control)obj17).Size = size;
		((Control)txtConfirm).TabIndex = 2;
		lblConfirm.AutoSize = true;
		Label obj18 = lblConfirm;
		location = new Point(256, 104);
		((Control)obj18).Location = location;
		((Control)lblConfirm).Name = "lblConfirm";
		Label obj19 = lblConfirm;
		size = new Size(53, 13);
		((Control)obj19).Size = size;
		((Control)lblConfirm).TabIndex = 6;
		lblConfirm.Text = "Xác nhận";
		txtFinal_day.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtFinal_day).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtFinal_day;
		location = new Point(149, 48);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtFinal_day).Mask = "##/##/####";
		((Control)txtFinal_day).Name = "txtFinal_day";
		((MaskedTextBox)txtFinal_day).PromptChar = ' ';
		((MaskedTextBox)txtFinal_day).ReadOnly = true;
		AsMaskedTextBox asMaskedTextBox2 = txtFinal_day;
		size = new Size(100, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtFinal_day).TabIndex = 7;
		((Control)txtFinal_day).TabStop = false;
		((MaskedTextBox)txtFinal_day).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtFinal_day;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(455, 185);
		((Form)this).ClientSize = size;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmINTransferINCDVT";
		((Form)this).Text = "Chuyển tồn kho sang năm sau";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override bool Execute()
	{
		((Control)cmdCancel).Enabled = false;
		((Control)cmdOK).Enabled = false;
		bgWorker.RunWorkerAsync();
		return true;
	}

	private void txtConfirm_TextChanged(object sender, EventArgs e)
	{
		if (txtConfirm.Text.CompareTo(txtMa_so.Text) == 0)
		{
			((Control)cmdOK).Enabled = true;
		}
		else
		{
			((Control)cmdOK).Enabled = false;
		}
	}

	protected override void InitComponents()
	{
		base.InitComponents();
		Random random = new Random();
		txtMa_so.Text = Conversions.ToString(random.Next());
		AsMaskedTextBox asMaskedTextBox = txtFinal_day;
		DateTime dateTime = new DateTime(SystemInformations.FinancialYear, 12, 31);
		asMaskedTextBox.Value = dateTime;
		((Control)cmdOK).Enabled = false;
	}

	private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtFinal_day.Value));
		arrayList.Add(((TextBox)txtMa_kho).Text.Trim());
		bSuccess = Conversions.ToBoolean(base.MyController.Execute(arrayList.ToArray()));
	}

	private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (bSuccess)
		{
			CMessageBox.Show(50015);
		}
		else
		{
			CMessageBox.Show(50010);
		}
		((Form)this).Close();
	}
}
