using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmGLTransferGLCDTK : frmCalc
{
	private IContainer components;

	[AccessedThroughProperty("lblSure")]
	private Label _lblSure;

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

	[AccessedThroughProperty("bgWork")]
	private BackgroundWorker _bgWork;

	private bool bSuccess;

	internal virtual Label lblSure
	{
		get
		{
			return _lblSure;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblSure = value;
		}
	}

	internal virtual Label lblFinal_day
	{
		get
		{
			return _lblFinal_day;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblFinal_day = value;
		}
	}

	internal virtual Label lblConfirm
	{
		get
		{
			return _lblConfirm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblConfirm = value;
		}
	}

	internal virtual Label lblMa_so
	{
		get
		{
			return _lblMa_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_so = value;
		}
	}

	internal virtual TextBox txtConfirm
	{
		get
		{
			return _txtConfirm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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
		get
		{
			return _txtMa_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_so = value;
		}
	}

	internal virtual AsMaskedTextBox txtFinal_day
	{
		get
		{
			return _txtFinal_day;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtFinal_day = value;
		}
	}

	internal virtual BackgroundWorker bgWork
	{
		get
		{
			return _bgWork;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			RunWorkerCompletedEventHandler value2 = bgWork_RunWorkerCompleted;
			DoWorkEventHandler value3 = bgWork_DoWork;
			if (_bgWork != null)
			{
				_bgWork.RunWorkerCompleted -= value2;
				_bgWork.DoWork -= value3;
			}
			_bgWork = value;
			if (_bgWork != null)
			{
				_bgWork.RunWorkerCompleted += value2;
				_bgWork.DoWork += value3;
			}
		}
	}

	public frmGLTransferGLCDTK(string MenuID)
		: base(MenuID)
	{
		bSuccess = false;
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
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		lblSure = new Label();
		lblFinal_day = new Label();
		lblMa_so = new Label();
		txtMa_so = new TextBox();
		txtConfirm = new TextBox();
		lblConfirm = new Label();
		txtFinal_day = new AsMaskedTextBox();
		bgWork = new BackgroundWorker();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 136);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		((Control)gbInput).Controls.Add((Control)(object)txtFinal_day);
		((Control)gbInput).Controls.Add((Control)(object)lblConfirm);
		((Control)gbInput).Controls.Add((Control)(object)lblMa_so);
		((Control)gbInput).Controls.Add((Control)(object)txtConfirm);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_so);
		((Control)gbInput).Controls.Add((Control)(object)lblFinal_day);
		((Control)gbInput).Controls.Add((Control)(object)lblSure);
		GroupBox obj2 = gbInput;
		Size size = new Size(433, 121);
		((Control)obj2).Size = size;
		((Control)gbInput).TabIndex = 0;
		Button obj3 = cmdOK;
		location = new Point(12, 136);
		((Control)obj3).Location = location;
		((Control)cmdOK).TabIndex = 1;
		lblSure.AutoSize = true;
		((Control)lblSure).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblSure).ForeColor = Color.Red;
		Label obj4 = lblSure;
		location = new Point(78, 16);
		((Control)obj4).Location = location;
		((Control)lblSure).Name = "lblSure";
		Label obj5 = lblSure;
		size = new Size(239, 13);
		((Control)obj5).Size = size;
		((Control)lblSure).TabIndex = 0;
		lblSure.Text = "Bạn có chắc muốn chuyển số dư sang năm sau?";
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
		lblMa_so.AutoSize = true;
		Label obj8 = lblMa_so;
		location = new Point(21, 80);
		((Control)obj8).Location = location;
		((Control)lblMa_so).Name = "lblMa_so";
		Label obj9 = lblMa_so;
		size = new Size(36, 13);
		((Control)obj9).Size = size;
		((Control)lblMa_so).TabIndex = 5;
		lblMa_so.Text = "Mã số";
		((Control)txtMa_so).Enabled = false;
		TextBox obj10 = txtMa_so;
		location = new Point(149, 76);
		((Control)obj10).Location = location;
		((Control)txtMa_so).Name = "txtMa_so";
		((TextBoxBase)txtMa_so).ReadOnly = true;
		TextBox obj11 = txtMa_so;
		size = new Size(101, 20);
		((Control)obj11).Size = size;
		((Control)txtMa_so).TabIndex = 0;
		TextBox obj12 = txtConfirm;
		location = new Point(317, 76);
		((Control)obj12).Location = location;
		((Control)txtConfirm).Name = "txtConfirm";
		TextBox obj13 = txtConfirm;
		size = new Size(101, 20);
		((Control)obj13).Size = size;
		((Control)txtConfirm).TabIndex = 1;
		lblConfirm.AutoSize = true;
		Label obj14 = lblConfirm;
		location = new Point(256, 80);
		((Control)obj14).Location = location;
		((Control)lblConfirm).Name = "lblConfirm";
		Label obj15 = lblConfirm;
		size = new Size(53, 13);
		((Control)obj15).Size = size;
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
		size = new Size(455, 168);
		((Form)this).ClientSize = size;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmGLTransferGLCDTK";
		((Form)this).Text = "Chuyển số dư tài khoản sang năm sau";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override bool Execute()
	{
		((Control)cmdCancel).Enabled = false;
		((Control)cmdOK).Enabled = false;
		bgWork.RunWorkerAsync();
		bool result = default(bool);
		return result;
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
		txtFinal_day.Value = AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_CnTc;
		((Control)cmdOK).Enabled = false;
		((Control)txtConfirm).Select();
	}

	private void bgWork_DoWork(object sender, DoWorkEventArgs e)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtFinal_day.Value));
		bSuccess = Conversions.ToBoolean(base.MyController.Execute(arrayList.ToArray()));
	}

	private void bgWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (bSuccess)
		{
			CMessageBox.Show(50015);
			((Form)this).Close();
		}
		else
		{
			CMessageBox.Show(50010);
		}
	}
}
