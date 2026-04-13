using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmConfirm : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtMa_AT")]
	private TextBox _txtMa_AT;

	[AccessedThroughProperty("txtConfirm")]
	private TextBox _txtConfirm;

	[AccessedThroughProperty("btnNhan")]
	private Button _btnNhan;

	[AccessedThroughProperty("btnThoat")]
	private Button _btnThoat;

	internal string Gia_tri;

	internal bool Su_dung;

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

	internal virtual TextBox txtMa_AT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_AT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_AT = value;
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
			_txtConfirm = value;
		}
	}

	internal virtual Button btnNhan
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnNhan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnNhan_Click;
			if (_btnNhan != null)
			{
				((Control)_btnNhan).Click -= eventHandler;
			}
			_btnNhan = value;
			if (_btnNhan != null)
			{
				((Control)_btnNhan).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnThoat
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnThoat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnThoat_Click;
			if (_btnThoat != null)
			{
				((Control)_btnThoat).Click -= eventHandler;
			}
			_btnThoat = value;
			if (_btnThoat != null)
			{
				((Control)_btnThoat).Click += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public frmConfirm()
	{
		((Form)this).Load += frmConfirm_Load;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		txtMa_AT = new TextBox();
		txtConfirm = new TextBox();
		btnNhan = new Button();
		btnThoat = new Button();
		((Control)this).SuspendLayout();
		Label1.AutoSize = true;
		((Control)Label1).ForeColor = Color.Red;
		Label label = Label1;
		Point location = new Point(23, 23);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		Size size = new Size(431, 26);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 0;
		Label1.Text = "Xác nhận lại việc thay đổi mã số bảo mật.\r\nChú ý: mã số boả mật sau khi thay đổi thì các hoá đơn đã in sẽ không còn kiểm tra đúng!";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(22, 68);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(61, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 1;
		Label2.Text = "Mã an toàn";
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(239, 68);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(89, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 2;
		Label3.Text = "Nhập mã an toàn";
		((Control)txtMa_AT).Enabled = false;
		TextBox obj = txtMa_AT;
		location = new Point(100, 64);
		((Control)obj).Location = location;
		((Control)txtMa_AT).Name = "txtMa_AT";
		TextBox obj2 = txtMa_AT;
		size = new Size(100, 20);
		((Control)obj2).Size = size;
		((Control)txtMa_AT).TabIndex = 3;
		TextBox obj3 = txtConfirm;
		location = new Point(342, 64);
		((Control)obj3).Location = location;
		((Control)txtConfirm).Name = "txtConfirm";
		TextBox obj4 = txtConfirm;
		size = new Size(100, 20);
		((Control)obj4).Size = size;
		((Control)txtConfirm).TabIndex = 4;
		Button obj5 = btnNhan;
		location = new Point(139, 105);
		((Control)obj5).Location = location;
		((Control)btnNhan).Name = "btnNhan";
		Button obj6 = btnNhan;
		size = new Size(75, 23);
		((Control)obj6).Size = size;
		((Control)btnNhan).TabIndex = 5;
		((ButtonBase)btnNhan).Text = "&Nhận";
		((ButtonBase)btnNhan).UseVisualStyleBackColor = true;
		Button obj7 = btnThoat;
		location = new Point(220, 105);
		((Control)obj7).Location = location;
		((Control)btnThoat).Name = "btnThoat";
		Button obj8 = btnThoat;
		size = new Size(75, 23);
		((Control)obj8).Size = size;
		((Control)btnThoat).TabIndex = 6;
		((ButtonBase)btnThoat).Text = "&Thoát";
		((ButtonBase)btnThoat).UseVisualStyleBackColor = true;
		((Form)this).AcceptButton = (IButtonControl)(object)btnNhan;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(477, 155);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)btnThoat);
		((Control)this).Controls.Add((Control)(object)btnNhan);
		((Control)this).Controls.Add((Control)(object)txtConfirm);
		((Control)this).Controls.Add((Control)(object)txtMa_AT);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Name = "frmConfirm";
		((Form)this).Text = "Xa\u0301c nhâ\u0323n thay mâ\u0323t khâ\u0309u";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 27)
		{
			((Form)this).Close();
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void frmConfirm_Load(object sender, EventArgs e)
	{
		GetCode();
	}

	private void btnThoat_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void btnNhan_Click(object sender, EventArgs e)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(txtMa_AT.Text, txtConfirm.Text, false) == 0)
		{
			SOND51bmhdDAO sOND51bmhdDAO = (SOND51bmhdDAO)DAOFactory.CreateDAOInstance("SOND51bmhdDAO", "SOND51bmhd");
			int num = sOND51bmhdDAO.Update(Gia_tri, Su_dung, isFirst: false);
			sOND51bmhdDAO.Destroy();
			((Form)this).Close();
		}
		else
		{
			CMessageBox.Show(50167);
			((Control)txtConfirm).Select();
		}
	}

	protected void GetCode()
	{
		Random random = new Random();
		txtMa_AT.Text = random.Next(10000000, 99999999).ToString();
	}
}
