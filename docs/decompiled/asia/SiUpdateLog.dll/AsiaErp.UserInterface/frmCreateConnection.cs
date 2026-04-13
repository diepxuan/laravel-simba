using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using AsiaErp.ToolCommon;
using Microsoft.VisualBasic.CompilerServices;
using My;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCreateConnection : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cboSrvInstance")]
	private ComboBox _cboSrvInstance;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("cboAuthentication")]
	private ComboBox _cboAuthentication;

	[AccessedThroughProperty("btnTestConnection")]
	private Button _btnTestConnection;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("cboDAOType")]
	private ComboBox _cboDAOType;

	[AccessedThroughProperty("txtpass")]
	private TextBox _txtpass;

	[AccessedThroughProperty("txtasData")]
	private TextBox _txtasData;

	[AccessedThroughProperty("txtasSys")]
	private TextBox _txtasSys;

	[AccessedThroughProperty("txtusername")]
	private TextBox _txtusername;

	[AccessedThroughProperty("lblUID")]
	private Label _lblUID;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("btnOk")]
	private Button _btnOk;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lblPWD")]
	private Label _lblPWD;

	[AccessedThroughProperty("btnCancel")]
	private Button _btnCancel;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("lblDbName")]
	private Label _lblDbName;

	[AccessedThroughProperty("cboTenDataBase")]
	private ComboBox _cboTenDataBase;

	private const string WINDOWS_AUTHENTICATION_TYPE = "WIN";

	private const string MSSQL_AUTHENTICATION_TYPE = "SQL";

	private string sDataCnnString;

	private string sSysCnnString;

	internal virtual ComboBox cboSrvInstance
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboSrvInstance;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboSrvInstance = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual ComboBox cboAuthentication
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboAuthentication;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboAuthentication_SelectedIndexChanged;
			if (_cboAuthentication != null)
			{
				_cboAuthentication.SelectedIndexChanged -= eventHandler;
			}
			_cboAuthentication = value;
			if (_cboAuthentication != null)
			{
				_cboAuthentication.SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual Button btnTestConnection
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnTestConnection;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnTestConnection_Click;
			if (_btnTestConnection != null)
			{
				((Control)_btnTestConnection).Click -= eventHandler;
			}
			_btnTestConnection = value;
			if (_btnTestConnection != null)
			{
				((Control)_btnTestConnection).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual ComboBox cboDAOType
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboDAOType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboDAOType = value;
		}
	}

	internal virtual TextBox txtpass
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtpass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtpass = value;
		}
	}

	internal virtual TextBox txtasData
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtasData;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtasData = value;
		}
	}

	internal virtual TextBox txtasSys
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtasSys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtasSys = value;
		}
	}

	internal virtual TextBox txtusername
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtusername;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtusername = value;
		}
	}

	internal virtual Label lblUID
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblUID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblUID = value;
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

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual Button btnOk
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnOk_Click;
			if (_btnOk != null)
			{
				((Control)_btnOk).Click -= eventHandler;
			}
			_btnOk = value;
			if (_btnOk != null)
			{
				((Control)_btnOk).Click += eventHandler;
			}
		}
	}

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

	internal virtual Label lblPWD
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPWD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPWD = value;
		}
	}

	internal virtual Button btnCancel
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnCancel_Click;
			if (_btnCancel != null)
			{
				((Control)_btnCancel).Click -= eventHandler;
			}
			_btnCancel = value;
			if (_btnCancel != null)
			{
				((Control)_btnCancel).Click += eventHandler;
			}
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

	internal virtual Label lblDbName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDbName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDbName = value;
		}
	}

	internal virtual ComboBox cboTenDataBase
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboTenDataBase;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboTenDataBase_Enter;
			if (_cboTenDataBase != null)
			{
				((Control)_cboTenDataBase).Enter -= eventHandler;
			}
			_cboTenDataBase = value;
			if (_cboTenDataBase != null)
			{
				((Control)_cboTenDataBase).Enter += eventHandler;
			}
		}
	}

	public frmCreateConnection()
	{
		((Form)this).Load += frmCreateConnection_Load;
		__ENCAddToList(this);
		sDataCnnString = string.Empty;
		sSysCnnString = string.Empty;
		InitializeComponent();
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

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
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
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		cboSrvInstance = new ComboBox();
		Label7 = new Label();
		cboAuthentication = new ComboBox();
		btnTestConnection = new Button();
		Label6 = new Label();
		cboDAOType = new ComboBox();
		txtpass = new TextBox();
		txtasData = new TextBox();
		txtasSys = new TextBox();
		txtusername = new TextBox();
		lblUID = new Label();
		Label3 = new Label();
		GroupBox1 = new GroupBox();
		btnOk = new Button();
		Label1 = new Label();
		lblPWD = new Label();
		btnCancel = new Button();
		Label2 = new Label();
		lblDbName = new Label();
		cboTenDataBase = new ComboBox();
		((Control)this).SuspendLayout();
		cboSrvInstance.DropDownWidth = 248;
		ComboBox obj = cboSrvInstance;
		Point location = new Point(132, 33);
		((Control)obj).Location = location;
		((Control)cboSrvInstance).Name = "cboSrvInstance";
		ComboBox obj2 = cboSrvInstance;
		Size size = new Size(248, 21);
		((Control)obj2).Size = size;
		((Control)cboSrvInstance).TabIndex = 1;
		Label label = Label7;
		location = new Point(12, 57);
		((Control)label).Location = location;
		((Control)Label7).Name = "Label7";
		Label label2 = Label7;
		size = new Size(96, 16);
		((Control)label2).Size = size;
		((Control)Label7).TabIndex = 11;
		Label7.Text = "Kiểu xác thực";
		Label7.TextAlign = (ContentAlignment)16;
		cboAuthentication.DropDownStyle = (ComboBoxStyle)2;
		cboAuthentication.DropDownWidth = 248;
		ComboBox obj3 = cboAuthentication;
		location = new Point(132, 57);
		((Control)obj3).Location = location;
		((Control)cboAuthentication).Name = "cboAuthentication";
		ComboBox obj4 = cboAuthentication;
		size = new Size(248, 21);
		((Control)obj4).Size = size;
		((Control)cboAuthentication).TabIndex = 2;
		Button obj5 = btnTestConnection;
		location = new Point(212, 173);
		((Control)obj5).Location = location;
		((Control)btnTestConnection).Name = "btnTestConnection";
		Button obj6 = btnTestConnection;
		size = new Size(80, 24);
		((Control)obj6).Size = size;
		((Control)btnTestConnection).TabIndex = 7;
		((ButtonBase)btnTestConnection).Text = "&Kiểm tra";
		Label label3 = Label6;
		location = new Point(12, 9);
		((Control)label3).Location = location;
		((Control)Label6).Name = "Label6";
		Label label4 = Label6;
		size = new Size(96, 16);
		((Control)label4).Size = size;
		((Control)Label6).TabIndex = 9;
		Label6.Text = "&Loại CSDL";
		Label6.TextAlign = (ContentAlignment)16;
		cboDAOType.DropDownStyle = (ComboBoxStyle)2;
		cboDAOType.DropDownWidth = 248;
		ComboBox obj7 = cboDAOType;
		location = new Point(132, 9);
		((Control)obj7).Location = location;
		((Control)cboDAOType).Name = "cboDAOType";
		ComboBox obj8 = cboDAOType;
		size = new Size(248, 21);
		((Control)obj8).Size = size;
		((Control)cboDAOType).TabIndex = 0;
		TextBox obj9 = txtpass;
		location = new Point(156, 105);
		((Control)obj9).Location = location;
		((Control)txtpass).Name = "txtpass";
		txtpass.PasswordChar = '*';
		TextBox obj10 = txtpass;
		size = new Size(224, 20);
		((Control)obj10).Size = size;
		((Control)txtpass).TabIndex = 4;
		TextBox obj11 = txtasData;
		location = new Point(567, 34);
		((Control)obj11).Location = location;
		((Control)txtasData).Name = "txtasData";
		TextBox obj12 = txtasData;
		size = new Size(248, 20);
		((Control)obj12).Size = size;
		((Control)txtasData).TabIndex = 44;
		txtasData.Text = "asData";
		((Control)txtasData).Visible = false;
		TextBox obj13 = txtasSys;
		location = new Point(567, 10);
		((Control)obj13).Location = location;
		((Control)txtasSys).Name = "txtasSys";
		TextBox obj14 = txtasSys;
		size = new Size(248, 20);
		((Control)obj14).Size = size;
		((Control)txtasSys).TabIndex = 42;
		txtasSys.Text = "asSys";
		((Control)txtasSys).Visible = false;
		TextBox obj15 = txtusername;
		location = new Point(156, 81);
		((Control)obj15).Location = location;
		((Control)txtusername).Name = "txtusername";
		TextBox obj16 = txtusername;
		size = new Size(224, 20);
		((Control)obj16).Size = size;
		((Control)txtusername).TabIndex = 3;
		txtusername.Text = "sa";
		Label obj17 = lblUID;
		location = new Point(36, 81);
		((Control)obj17).Location = location;
		((Control)lblUID).Name = "lblUID";
		Label obj18 = lblUID;
		size = new Size(96, 16);
		((Control)obj18).Size = size;
		((Control)lblUID).TabIndex = 12;
		lblUID.Text = "Tên đăng &nhập";
		lblUID.TextAlign = (ContentAlignment)16;
		Label label5 = Label3;
		location = new Point(447, 34);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(120, 16);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 43;
		Label3.Text = "Tên &DATA database";
		Label3.TextAlign = (ContentAlignment)16;
		((Control)Label3).Visible = false;
		GroupBox groupBox = GroupBox1;
		location = new Point(20, 163);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(360, 4);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 15;
		GroupBox1.TabStop = false;
		Button obj19 = btnOk;
		location = new Point(124, 173);
		((Control)obj19).Location = location;
		((Control)btnOk).Name = "btnOk";
		Button obj20 = btnOk;
		size = new Size(80, 24);
		((Control)obj20).Size = size;
		((Control)btnOk).TabIndex = 6;
		((ButtonBase)btnOk).Text = "&Tạo kết nối";
		Label label7 = Label1;
		location = new Point(12, 33);
		((Control)label7).Location = location;
		((Control)Label1).Name = "Label1";
		Label label8 = Label1;
		size = new Size(96, 16);
		((Control)label8).Size = size;
		((Control)Label1).TabIndex = 10;
		Label1.Text = "Tên máy &chủ";
		Label1.TextAlign = (ContentAlignment)16;
		Label obj21 = lblPWD;
		location = new Point(36, 105);
		((Control)obj21).Location = location;
		((Control)lblPWD).Name = "lblPWD";
		Label obj22 = lblPWD;
		size = new Size(96, 16);
		((Control)obj22).Size = size;
		((Control)lblPWD).TabIndex = 13;
		lblPWD.Text = "Mật &khẩu";
		lblPWD.TextAlign = (ContentAlignment)16;
		btnCancel.DialogResult = (DialogResult)2;
		Button obj23 = btnCancel;
		location = new Point(300, 173);
		((Control)obj23).Location = location;
		((Control)btnCancel).Name = "btnCancel";
		Button obj24 = btnCancel;
		size = new Size(80, 24);
		((Control)obj24).Size = size;
		((Control)btnCancel).TabIndex = 8;
		((ButtonBase)btnCancel).Text = "T&hoát";
		Label label9 = Label2;
		location = new Point(447, 10);
		((Control)label9).Location = location;
		((Control)Label2).Name = "Label2";
		Label label10 = Label2;
		size = new Size(104, 16);
		((Control)label10).Size = size;
		((Control)Label2).TabIndex = 40;
		Label2.Text = "Tên &SYS database";
		Label2.TextAlign = (ContentAlignment)16;
		((Control)Label2).Visible = false;
		Label obj25 = lblDbName;
		location = new Point(36, 131);
		((Control)obj25).Location = location;
		((Control)lblDbName).Name = "lblDbName";
		Label obj26 = lblDbName;
		size = new Size(96, 16);
		((Control)obj26).Size = size;
		((Control)lblDbName).TabIndex = 14;
		lblDbName.Text = "Tên database";
		lblDbName.TextAlign = (ContentAlignment)16;
		cboTenDataBase.DropDownWidth = 248;
		ComboBox obj27 = cboTenDataBase;
		location = new Point(156, 131);
		((Control)obj27).Location = location;
		((Control)cboTenDataBase).Name = "cboTenDataBase";
		ComboBox obj28 = cboTenDataBase;
		size = new Size(224, 21);
		((Control)obj28).Size = size;
		((Control)cboTenDataBase).TabIndex = 5;
		((Form)this).AcceptButton = (IButtonControl)(object)btnOk;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(404, 207);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)lblDbName);
		((Control)this).Controls.Add((Control)(object)cboTenDataBase);
		((Control)this).Controls.Add((Control)(object)cboSrvInstance);
		((Control)this).Controls.Add((Control)(object)Label7);
		((Control)this).Controls.Add((Control)(object)cboAuthentication);
		((Control)this).Controls.Add((Control)(object)btnTestConnection);
		((Control)this).Controls.Add((Control)(object)Label6);
		((Control)this).Controls.Add((Control)(object)cboDAOType);
		((Control)this).Controls.Add((Control)(object)txtpass);
		((Control)this).Controls.Add((Control)(object)txtasData);
		((Control)this).Controls.Add((Control)(object)txtasSys);
		((Control)this).Controls.Add((Control)(object)txtusername);
		((Control)this).Controls.Add((Control)(object)lblUID);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Control)this).Controls.Add((Control)(object)btnOk);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)lblPWD);
		((Control)this).Controls.Add((Control)(object)btnCancel);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmCreateConnection";
		((Form)this).Text = "CreateConnection";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmCreateConnection_Load(object sender, EventArgs e)
	{
		ComboBox val = cboDAOType;
		ObjectCollection items = cboDAOType.Items;
		DictionaryEntry dictionaryEntry = new DictionaryEntry("MsSql", "SQL Server");
		items.Add((object)dictionaryEntry);
		((ListControl)cboDAOType).DisplayMember = "Value";
		((ListControl)cboDAOType).ValueMember = "Key";
		cboDAOType.SelectedIndex = 0;
		val = null;
		ComboBox val2 = cboAuthentication;
		ObjectCollection items2 = cboAuthentication.Items;
		dictionaryEntry = new DictionaryEntry("SQL", "SQL Server");
		items2.Add((object)dictionaryEntry);
		ObjectCollection items3 = cboAuthentication.Items;
		dictionaryEntry = new DictionaryEntry("WIN", "Windows");
		items3.Add((object)dictionaryEntry);
		((ListControl)cboAuthentication).DisplayMember = "Value";
		((ListControl)cboAuthentication).ValueMember = "Key";
		val2 = null;
		LoadDefautConnect();
	}

	private void btnOk_Click(object sender, EventArgs e)
	{
		if (CheckConnection())
		{
			TCommon.set_Session((object)"DaoType", (object)Commons.GetCboValue(cboDAOType));
			TCommon.set_Session((object)"AuthenticationType", (object)Commons.GetCboValue(cboAuthentication));
			TCommon.set_Session((object)"SqlServerName", (object)cboSrvInstance.Text);
			TCommon.set_Session((object)"SqlUserName", (object)txtusername.Text.Trim());
			TCommon.set_Session((object)"SqlPassword", (object)txtpass.Text.Trim());
			TCommon.set_Session((object)"SqlDataDBName", (object)cboTenDataBase.Text.Trim());
			TCommon.set_Session((object)"sDataCnnString", (object)sDataCnnString);
			((Form)this).DialogResult = (DialogResult)1;
			((Form)this).Close();
		}
	}

	private void btnTestConnection_Click(object sender, EventArgs e)
	{
		CheckConnection();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void cboAuthentication_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(Commons.GetCboValue(cboAuthentication), "WIN", false) == 0)
		{
			txtusername.Text = My.MyProject.User.Name;
			txtpass.Text = "************";
			((Control)txtusername).Enabled = false;
			((Control)txtpass).Enabled = false;
			((Control)lblUID).Enabled = false;
			((Control)lblPWD).Enabled = false;
		}
		else
		{
			((Control)txtusername).Enabled = true;
			((Control)txtpass).Enabled = true;
			((Control)lblUID).Enabled = true;
			((Control)lblPWD).Enabled = true;
		}
	}

	private void cboTenDataBase_Enter(object sender, EventArgs e)
	{
		GetAllDatabaseNameToCombo();
	}

	public void LoadDefautConnect()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ExeConfigurationFileMap val = new ExeConfigurationFileMap();
		val.ExeConfigFilename = Application.StartupPath + "\\Startup.exe.config";
		if (File.Exists(val.ExeConfigFilename))
		{
			Configuration val2 = ConfigurationManager.OpenMappedExeConfiguration(val, (ConfigurationUserLevel)0);
			cboSrvInstance.Text = Helper.Decrypted(val2.AppSettings.Settings["SqlServerName"].Value, 125);
			Commons.SetCboValue(cboDAOType, val2.AppSettings.Settings["DaoType"].Value);
			Commons.SetCboValue(cboAuthentication, val2.AppSettings.Settings["AuthenticationType"].Value);
			if (Operators.CompareString(Commons.GetCboValue(cboAuthentication), "WIN", false) == 0)
			{
				txtusername.Text = "";
				txtpass.Text = "************";
			}
			else
			{
				txtusername.Text = Helper.Decrypted(val2.AppSettings.Settings["SqlUserName"].Value, 126);
				txtpass.Text = Helper.Decrypted(val2.AppSettings.Settings["SqlPassword"].Value, 127);
			}
			GetAllDatabaseNameToCombo();
			cboTenDataBase.Text = Helper.Decrypted(val2.AppSettings.Settings["SqlDataDBName"].Value, 125);
		}
	}

	private bool CheckConnection()
	{
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string cboValue = Commons.GetCboValue(cboAuthentication);
			if (Operators.CompareString(cboValue, "SQL", false) == 0)
			{
				sDataCnnString = $"Server={cboSrvInstance.Text};Uid={txtusername.Text.Trim()};Pwd={txtpass.Text.Trim()};Database={cboTenDataBase.Text.Trim()};Integrated Security=no";
			}
			else
			{
				sDataCnnString = $"Server={cboSrvInstance.Text};Database={cboTenDataBase.Text.Trim()};Integrated Security=Yes";
			}
			if (!TestConnection(sDataCnnString))
			{
				CMessageBox.Show("Kết nối không thành công");
				return false;
			}
			CMessageBox.Show("Kết nối thành công");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return true;
	}

	private void GetAllDatabaseNameToCombo()
	{
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_016c: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		string empty = string.Empty;
		string cboValue = Commons.GetCboValue(cboAuthentication);
		if (Operators.CompareString(cboValue, "SQL", false) == 0)
		{
			if ((Operators.CompareString(cboSrvInstance.Text.Trim(), string.Empty, false) == 0 && Operators.CompareString(txtusername.Text.Trim(), string.Empty, false) == 0 && Operators.CompareString(txtpass.Text.Trim(), string.Empty, false) == 0) ? true : false)
			{
				return;
			}
			empty = $"Server={cboSrvInstance.Text.Trim()};Uid={txtusername.Text.Trim()};Pwd={txtpass.Text.Trim()};Database=master;Integrated Security=no";
		}
		else
		{
			if (Operators.CompareString(cboSrvInstance.Text, string.Empty, false) == 0)
			{
				return;
			}
			empty = $"Server={cboSrvInstance.Text};Database=master;Integrated Security=Yes";
		}
		SqlDataAdapter val = new SqlDataAdapter();
		DataTable dataTable = new DataTable();
		try
		{
			IDbConnection dbConnection = (IDbConnection)new SqlConnection(empty);
			dbConnection.Open();
			SqlCommand val2 = (SqlCommand)dbConnection.CreateCommand();
			val2.CommandType = CommandType.Text;
			val2.CommandText = "SELECT name, database_id FROM sys.databases ORDER BY name";
			val.SelectCommand = val2;
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		catch (SqlException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			SqlException ex2 = ex;
			string text = $"Không thể kết nối đến server {cboSrvInstance.Text}";
			CMessageBox.Show(text);
			Helper.ProcessError(((Exception)(object)ex2).ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			((Component)(object)val).Dispose();
		}
		try
		{
			cboTenDataBase.DataSource = dataTable;
			((ListControl)cboTenDataBase).DisplayMember = "name";
			((ListControl)cboTenDataBase).ValueMember = "database_id";
			cboTenDataBase.Text = "";
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			throw ex4;
		}
	}

	private bool TestConnection(string sCnnString)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		string cboValue = Commons.GetCboValue(cboDAOType);
		IDbConnection dbConnection = null;
		bool result;
		try
		{
			string text = cboValue;
			if (Operators.CompareString(text, "Oracle", false) != 0)
			{
				if (Operators.CompareString(text, "MsSql", false) != 0)
				{
					throw new NotSupportedException("Data Access Object type not supported");
				}
				dbConnection = (IDbConnection)new SqlConnection(sCnnString);
			}
			dbConnection.Open();
			dbConnection.Close();
			dbConnection.Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(ex2.Message);
			result = false;
			ProjectData.ClearProjectError();
			goto IL_00a0;
		}
		result = true;
		goto IL_00a0;
		IL_00a0:
		return result;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 27)
		{
			((Form)this).Close();
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}
}
