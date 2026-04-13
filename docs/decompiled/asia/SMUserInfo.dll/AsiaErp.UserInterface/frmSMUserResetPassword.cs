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
public class frmSMUserResetPassword : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdSave")]
	private Button _cmdSave;

	[AccessedThroughProperty("lblNewPassword")]
	private Label _lblNewPassword;

	[AccessedThroughProperty("txtPassword")]
	private TextBox _txtPassword;

	[AccessedThroughProperty("txtRePassword")]
	private TextBox _txtRePassword;

	[AccessedThroughProperty("lblRePassword")]
	private Label _lblRePassword;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("epNotice")]
	private ErrorProvider _epNotice;

	private SMUserInfoController oController;

	internal UserInfo oUserInfo;

	internal string sUserName;

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

	internal virtual TextBox txtPassword
	{
		get
		{
			return _txtPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtPassword = value;
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

	public frmSMUserResetPassword()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmSMUserResetPassword_KeyDown);
		((Form)this).Load += frmSMUserChangePassword_Load;
		oController = new SMUserInfoController();
		sUserName = "";
		InitializeComponent();
	}

	public frmSMUserResetPassword(string menuid)
		: base(menuid)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmSMUserResetPassword_KeyDown);
		((Form)this).Load += frmSMUserChangePassword_Load;
		oController = new SMUserInfoController();
		sUserName = "";
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSMUserResetPassword));
		cmdCancel = new Button();
		cmdSave = new Button();
		lblNewPassword = new Label();
		txtPassword = new TextBox();
		txtRePassword = new TextBox();
		lblRePassword = new Label();
		GroupBox1 = new GroupBox();
		epNotice = new ErrorProvider(components);
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)this).SuspendLayout();
		((Control)cmdCancel).Anchor = (AnchorStyles)6;
		cmdCancel.DialogResult = (DialogResult)2;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		((ButtonBase)cmdCancel).Image = (Image)componentResourceManager.GetObject("cmdCancel.Image");
		((ButtonBase)cmdCancel).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdCancel).ImeMode = (ImeMode)0;
		Button obj = cmdCancel;
		Point location = new Point(93, 95);
		((Control)obj).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj2 = cmdCancel;
		Size size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)cmdCancel).TabIndex = 2;
		((ButtonBase)cmdCancel).Text = "&Huỷ bỏ";
		((ButtonBase)cmdCancel).TextAlign = (ContentAlignment)64;
		((Control)cmdSave).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdSave).Image = (Image)componentResourceManager.GetObject("cmdSave.Image");
		((ButtonBase)cmdSave).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdSave).ImeMode = (ImeMode)0;
		Button obj3 = cmdSave;
		location = new Point(12, 95);
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
		location = new Point(13, 22);
		((Control)obj5).Location = location;
		((Control)lblNewPassword).Name = "lblNewPassword";
		Label obj6 = lblNewPassword;
		size = new Size(112, 16);
		((Control)obj6).Size = size;
		((Control)lblNewPassword).TabIndex = 19;
		lblNewPassword.Text = "Mật khẩu mới";
		((Control)txtPassword).ImeMode = (ImeMode)0;
		TextBox obj7 = txtPassword;
		location = new Point(179, 19);
		((Control)obj7).Location = location;
		((TextBoxBase)txtPassword).MaxLength = 30;
		((Control)txtPassword).Name = "txtPassword";
		txtPassword.PasswordChar = '*';
		TextBox obj8 = txtPassword;
		size = new Size(142, 20);
		((Control)obj8).Size = size;
		((Control)txtPassword).TabIndex = 1;
		((Control)txtRePassword).ImeMode = (ImeMode)0;
		TextBox obj9 = txtRePassword;
		location = new Point(179, 45);
		((Control)obj9).Location = location;
		((TextBoxBase)txtRePassword).MaxLength = 30;
		((Control)txtRePassword).Name = "txtRePassword";
		txtRePassword.PasswordChar = '*';
		TextBox obj10 = txtRePassword;
		size = new Size(142, 20);
		((Control)obj10).Size = size;
		((Control)txtRePassword).TabIndex = 2;
		lblRePassword.ImeMode = (ImeMode)0;
		Label obj11 = lblRePassword;
		location = new Point(13, 48);
		((Control)obj11).Location = location;
		((Control)lblRePassword).Name = "lblRePassword";
		Label obj12 = lblRePassword;
		size = new Size(125, 17);
		((Control)obj12).Size = size;
		((Control)lblRePassword).TabIndex = 20;
		lblRePassword.Text = "Nhập lại mật khẩu mới";
		((Control)GroupBox1).Controls.Add((Control)(object)lblRePassword);
		((Control)GroupBox1).Controls.Add((Control)(object)txtRePassword);
		((Control)GroupBox1).Controls.Add((Control)(object)lblNewPassword);
		((Control)GroupBox1).Controls.Add((Control)(object)txtPassword);
		GroupBox groupBox = GroupBox1;
		location = new Point(12, 6);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(327, 78);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 0;
		GroupBox1.TabStop = false;
		epNotice.ContainerControl = (ContainerControl)(object)this;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(351, 130);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdSave);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "frmSMUserResetPassword";
		((Form)this).Text = "Đặt lại mât khẩu";
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)epNotice).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void cmdSave_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (ValidData() && oController.ChangePassword(sUserName, Helper.Encrypted(txtPassword.Text.Trim(), 100)))
		{
			CMessageBox.Show(50015);
			((Form)this).Close();
		}
	}

	private bool ValidData()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(oUserInfo.isadmin, (object)false, false))
		{
			CMessageBox.Show(50005);
			return false;
		}
		if (Operators.CompareString(txtPassword.Text.Trim(), txtRePassword.Text.Trim(), false) != 0)
		{
			epNotice.SetError((Control)(object)txtPassword, Helper.GetMessContent(50084));
			((Control)txtPassword).Focus();
			((Control)txtPassword).Select();
			return false;
		}
		return true;
	}

	private void frmSMUserChangePassword_Load(object sender, EventArgs e)
	{
		oUserInfo = oController.GetUserInfoByUserName(SystemInformations.UserName);
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void frmSMUserResetPassword_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
	}
}
