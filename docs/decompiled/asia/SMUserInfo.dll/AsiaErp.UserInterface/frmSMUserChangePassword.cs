using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using DTE.Bussiness;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSMUserChangePassword : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdSave")]
	private Button _cmdSave;

	[AccessedThroughProperty("lblNewPassword")]
	private Label _lblNewPassword;

	[AccessedThroughProperty("txtNewPassword")]
	private TextBox _txtNewPassword;

	[AccessedThroughProperty("txtRePassword")]
	private TextBox _txtRePassword;

	[AccessedThroughProperty("lblRePassword")]
	private Label _lblRePassword;

	[AccessedThroughProperty("lblOldPassword")]
	private Label _lblOldPassword;

	[AccessedThroughProperty("txtOld_Password")]
	private TextBox _txtOld_Password;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("epNotice")]
	private ErrorProvider _epNotice;

	private SMUserInfoController oController;

	private UserInfo oUserInfo;

	protected virtual Button cmdCancel
	{
		get
		{
			return _cmdCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdCancel_Click;
			if (_cmdCancel != null)
			{
				((Control)_cmdCancel).Click -= eventHandler;
			}
			_cmdCancel = value;
			if (_cmdCancel != null)
			{
				((Control)_cmdCancel).Click += eventHandler;
			}
		}
	}

	protected virtual Button cmdSave
	{
		get
		{
			return _cmdSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdSave_Click;
			if (_cmdSave != null)
			{
				((Control)_cmdSave).Click -= eventHandler;
			}
			_cmdSave = value;
			if (_cmdSave != null)
			{
				((Control)_cmdSave).Click += eventHandler;
			}
		}
	}

	internal virtual Label lblNewPassword
	{
		get
		{
			return _lblNewPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblNewPassword = value;
		}
	}

	internal virtual TextBox txtNewPassword
	{
		get
		{
			return _txtNewPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtNewPassword = value;
		}
	}

	internal virtual TextBox txtRePassword
	{
		get
		{
			return _txtRePassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtRePassword = value;
		}
	}

	internal virtual Label lblRePassword
	{
		get
		{
			return _lblRePassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblRePassword = value;
		}
	}

	internal virtual Label lblOldPassword
	{
		get
		{
			return _lblOldPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblOldPassword = value;
		}
	}

	internal virtual TextBox txtOld_Password
	{
		get
		{
			return _txtOld_Password;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtOld_Password = value;
		}
	}

	internal virtual GroupBox GroupBox1
	{
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GroupBox1 = value;
		}
	}

	protected virtual ErrorProvider epNotice
	{
		get
		{
			return _epNotice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_epNotice = value;
		}
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

	public frmSMUserChangePassword()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmSMUserChangePassword_KeyDown);
		((Form)this).Load += frmSMUserChangePassword_Load;
		oController = new SMUserInfoController();
		InitializeComponent();
	}

	public frmSMUserChangePassword(string menuid)
		: base(menuid)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmSMUserChangePassword_KeyDown);
		((Form)this).Load += frmSMUserChangePassword_Load;
		oController = new SMUserInfoController();
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSMUserChangePassword));
		cmdCancel = new Button();
		cmdSave = new Button();
		lblNewPassword = new Label();
		txtNewPassword = new TextBox();
		txtRePassword = new TextBox();
		lblRePassword = new Label();
		lblOldPassword = new Label();
		txtOld_Password = new TextBox();
		GroupBox1 = new GroupBox();
		epNotice = new ErrorProvider(components);
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)this).SuspendLayout();
		cmdCancel.DialogResult = (DialogResult)2;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		((ButtonBase)cmdCancel).Image = (Image)componentResourceManager.GetObject("cmdCancel.Image");
		((ButtonBase)cmdCancel).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdCancel).ImeMode = (ImeMode)0;
		Button obj = cmdCancel;
		Point location = new Point(93, 128);
		((Control)obj).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj2 = cmdCancel;
		Size size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)cmdCancel).TabIndex = 2;
		((ButtonBase)cmdCancel).Text = "&Huỷ bỏ";
		((ButtonBase)cmdCancel).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdSave).Image = (Image)componentResourceManager.GetObject("cmdSave.Image");
		((ButtonBase)cmdSave).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdSave).ImeMode = (ImeMode)0;
		Button obj3 = cmdSave;
		location = new Point(12, 128);
		((Control)obj3).Location = location;
		((Control)cmdSave).Name = "cmdSave";
		Button obj4 = cmdSave;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)cmdSave).TabIndex = 1;
		((ButtonBase)cmdSave).Text = "&Lưu";
		((ButtonBase)cmdSave).TextAlign = (ContentAlignment)64;
		lblNewPassword.ImeMode = (ImeMode)0;
		Label obj5 = lblNewPassword;
		location = new Point(12, 47);
		((Control)obj5).Location = location;
		((Control)lblNewPassword).Name = "lblNewPassword";
		Label obj6 = lblNewPassword;
		size = new Size(72, 16);
		((Control)obj6).Size = size;
		((Control)lblNewPassword).TabIndex = 19;
		lblNewPassword.Text = "Mật khẩu mới";
		((Control)txtNewPassword).ImeMode = (ImeMode)0;
		TextBox obj7 = txtNewPassword;
		location = new Point(120, 45);
		((Control)obj7).Location = location;
		((TextBoxBase)txtNewPassword).MaxLength = 30;
		((Control)txtNewPassword).Name = "txtNewPassword";
		txtNewPassword.PasswordChar = '*';
		TextBox obj8 = txtNewPassword;
		size = new Size(112, 20);
		((Control)obj8).Size = size;
		((Control)txtNewPassword).TabIndex = 1;
		((Control)txtRePassword).ImeMode = (ImeMode)0;
		TextBox obj9 = txtRePassword;
		location = new Point(120, 71);
		((Control)obj9).Location = location;
		((TextBoxBase)txtRePassword).MaxLength = 30;
		((Control)txtRePassword).Name = "txtRePassword";
		txtRePassword.PasswordChar = '*';
		TextBox obj10 = txtRePassword;
		size = new Size(112, 20);
		((Control)obj10).Size = size;
		((Control)txtRePassword).TabIndex = 2;
		lblRePassword.ImeMode = (ImeMode)0;
		Label obj11 = lblRePassword;
		location = new Point(12, 73);
		((Control)obj11).Location = location;
		((Control)lblRePassword).Name = "lblRePassword";
		Label obj12 = lblRePassword;
		size = new Size(97, 16);
		((Control)obj12).Size = size;
		((Control)lblRePassword).TabIndex = 20;
		lblRePassword.Text = "Nhập lại mật khẩu";
		lblOldPassword.ImeMode = (ImeMode)0;
		Label obj13 = lblOldPassword;
		location = new Point(12, 21);
		((Control)obj13).Location = location;
		((Control)lblOldPassword).Name = "lblOldPassword";
		Label obj14 = lblOldPassword;
		size = new Size(72, 16);
		((Control)obj14).Size = size;
		((Control)lblOldPassword).TabIndex = 22;
		lblOldPassword.Text = "Mật khẩu cũ";
		((Control)txtOld_Password).ImeMode = (ImeMode)0;
		TextBox obj15 = txtOld_Password;
		location = new Point(120, 19);
		((Control)obj15).Location = location;
		((TextBoxBase)txtOld_Password).MaxLength = 30;
		((Control)txtOld_Password).Name = "txtOld_Password";
		txtOld_Password.PasswordChar = '*';
		TextBox obj16 = txtOld_Password;
		size = new Size(112, 20);
		((Control)obj16).Size = size;
		((Control)txtOld_Password).TabIndex = 0;
		((Control)GroupBox1).Controls.Add((Control)(object)txtOld_Password);
		((Control)GroupBox1).Controls.Add((Control)(object)lblOldPassword);
		((Control)GroupBox1).Controls.Add((Control)(object)lblRePassword);
		((Control)GroupBox1).Controls.Add((Control)(object)txtRePassword);
		((Control)GroupBox1).Controls.Add((Control)(object)lblNewPassword);
		((Control)GroupBox1).Controls.Add((Control)(object)txtNewPassword);
		GroupBox groupBox = GroupBox1;
		location = new Point(12, 12);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(290, 110);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 0;
		GroupBox1.TabStop = false;
		epNotice.ContainerControl = (ContainerControl)(object)this;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(314, 157);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdSave);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "frmSMUserChangePassword";
		((Form)this).Text = "Thay đổi mật khẩu";
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)epNotice).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void cmdSave_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (ValidData() && oController.ChangePassword(SystemInformations.UserName, Helper.Encrypted(txtNewPassword.Text.Trim(), 100)))
		{
			CMessageBox.Show(50015);
			((Form)this).Close();
		}
	}

	private bool ValidData()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Helper.Encrypted(txtOld_Password.Text.Trim(), 100), oUserInfo.password, false) != 0)
		{
			((Control)txtOld_Password).Focus();
			((Control)txtOld_Password).Select();
			CMessageBox.Show(50135);
			return false;
		}
		if (Operators.CompareString(txtNewPassword.Text.Trim(), txtRePassword.Text.Trim(), false) != 0)
		{
			epNotice.SetError((Control)(object)txtNewPassword, Helper.GetMessContent(50084));
			((Control)txtNewPassword).Focus();
			((Control)txtNewPassword).Select();
			return false;
		}
		return true;
	}

	private void frmSMUserChangePassword_Load(object sender, EventArgs e)
	{
		oUserInfo = oController.GetUserInfoByUserName(SystemInformations.UserName);
		((Control)txtOld_Password).Focus();
		((Control)txtOld_Password).Select();
		((Form)this).Text = MyMenuInfo.bar;
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void frmSMUserChangePassword_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
	}
}
