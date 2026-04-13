using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmRegister : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("lblError")]
	private Label _lblError;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("cmdExit")]
	private Button _cmdExit;

	[AccessedThroughProperty("cmdRegister")]
	private Button _cmdRegister;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("lblAsiasoft")]
	private LinkLabel _lblAsiasoft;

	[AccessedThroughProperty("txtSerialNumber")]
	private TextBox _txtSerialNumber;

	[AccessedThroughProperty("cmdFile")]
	private Button _cmdFile;

	private Helper.CryptographyData KEY;

	private const string MyWebsite = "http://www.asiasoft.com.vn";

	private string f_sUserName;

	private string f_sSerialNumber;

	public string RegSubKeyName;

	public bool ActivateSuccess;

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual Label lblError
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblError;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblError = value;
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

	internal virtual PictureBox PictureBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox2_Click;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).Click -= eventHandler;
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).Click += eventHandler;
			}
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

	internal virtual Button cmdExit
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdExit_Click;
			if (_cmdExit != null)
			{
				((Control)_cmdExit).Click -= eventHandler;
			}
			_cmdExit = value;
			if (_cmdExit != null)
			{
				((Control)_cmdExit).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdRegister
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRegister;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRegister_Click;
			if (_cmdRegister != null)
			{
				((Control)_cmdRegister).Click -= eventHandler;
			}
			_cmdRegister = value;
			if (_cmdRegister != null)
			{
				((Control)_cmdRegister).Click += eventHandler;
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

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual LinkLabel lblAsiasoft
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblAsiasoft;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(lblAsiasoft_LinkClicked);
			if (_lblAsiasoft != null)
			{
				_lblAsiasoft.LinkClicked -= val;
			}
			_lblAsiasoft = value;
			if (_lblAsiasoft != null)
			{
				_lblAsiasoft.LinkClicked += val;
			}
		}
	}

	internal virtual TextBox txtSerialNumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSerialNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSerialNumber = value;
		}
	}

	internal virtual Button cmdFile
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdFile_Click;
			if (_cmdFile != null)
			{
				((Control)_cmdFile).Click -= eventHandler;
			}
			_cmdFile = value;
			if (_cmdFile != null)
			{
				((Control)_cmdFile).Click += eventHandler;
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

	public frmRegister()
	{
		((Form)this).Load += frmRegister_Load;
		__ENCAddToList(this);
		KEY = new Helper.CryptographyData(SystemInformations.ProductName);
		f_sUserName = "";
		f_sSerialNumber = "";
		RegSubKeyName = "Asiasoft\\\\Asia Enterprise\\\\12.1.3";
		ActivateSuccess = false;
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
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
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected O, but got Unknown
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected O, but got Unknown
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmRegister));
		Panel1 = new Panel();
		cmdFile = new Button();
		PictureBox2 = new PictureBox();
		lblError = new Label();
		Label3 = new Label();
		txtSerialNumber = new TextBox();
		lblAsiasoft = new LinkLabel();
		Label4 = new Label();
		GroupBox1 = new GroupBox();
		cmdExit = new Button();
		Label1 = new Label();
		cmdRegister = new Button();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).Controls.Add((Control)(object)cmdFile);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox2);
		((Control)Panel1).Controls.Add((Control)(object)lblError);
		((Control)Panel1).Controls.Add((Control)(object)Label3);
		((Control)Panel1).Controls.Add((Control)(object)txtSerialNumber);
		Panel panel = Panel1;
		Point location = new Point(0, 0);
		((Control)panel).Location = location;
		Panel panel2 = Panel1;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(0);
		((Control)panel2).Margin = margin;
		((Control)Panel1).Name = "Panel1";
		Panel panel3 = Panel1;
		Size size = new Size(502, 145);
		((Control)panel3).Size = size;
		((Control)Panel1).TabIndex = 0;
		Button obj = cmdFile;
		location = new Point(430, 91);
		((Control)obj).Location = location;
		((Control)cmdFile).Name = "cmdFile";
		Button obj2 = cmdFile;
		size = new Size(50, 23);
		((Control)obj2).Size = size;
		((Control)cmdFile).TabIndex = 20;
		((ButtonBase)cmdFile).Text = "Chọn";
		((ButtonBase)cmdFile).UseVisualStyleBackColor = true;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox = PictureBox2;
		location = new Point(0, 0);
		((Control)pictureBox).Location = location;
		PictureBox pictureBox2 = PictureBox2;
		((Padding)(ref margin))._002Ector(0);
		((Control)pictureBox2).Margin = margin;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox3 = PictureBox2;
		size = new Size(502, 61);
		((Control)pictureBox3).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)1;
		PictureBox2.TabIndex = 19;
		PictureBox2.TabStop = false;
		lblError.AutoSize = true;
		((Control)lblError).BackColor = Color.Transparent;
		((Control)lblError).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblError).ForeColor = Color.Red;
		Label obj3 = lblError;
		location = new Point(19, 120);
		((Control)obj3).Location = location;
		((Control)lblError).Name = "lblError";
		Label obj4 = lblError;
		size = new Size(256, 13);
		((Control)obj4).Size = size;
		((Control)lblError).TabIndex = 18;
		lblError.Text = "Thông tin đăng ký bản quyền không hợp lệ.";
		((Control)lblError).Visible = false;
		Label3.AutoSize = true;
		((Control)Label3).BackColor = Color.Transparent;
		((Control)Label3).ForeColor = Color.Black;
		Label label = Label3;
		location = new Point(19, 73);
		((Control)label).Location = location;
		((Control)Label3).Name = "Label3";
		Label label2 = Label3;
		size = new Size(72, 13);
		((Control)label2).Size = size;
		((Control)Label3).TabIndex = 17;
		Label3.Text = "File kích hoạt";
		Label3.TextAlign = (ContentAlignment)32;
		((TextBoxBase)txtSerialNumber).BackColor = SystemColors.Info;
		((Control)txtSerialNumber).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtSerialNumber).ForeColor = Color.Black;
		TextBox obj5 = txtSerialNumber;
		location = new Point(22, 92);
		((Control)obj5).Location = location;
		((Control)txtSerialNumber).Name = "txtSerialNumber";
		TextBox obj6 = txtSerialNumber;
		size = new Size(402, 20);
		((Control)obj6).Size = size;
		((Control)txtSerialNumber).TabIndex = 1;
		lblAsiasoft.ActiveLinkColor = Color.Blue;
		((Label)lblAsiasoft).AutoSize = true;
		lblAsiasoft.LinkBehavior = (LinkBehavior)2;
		LinkLabel obj7 = lblAsiasoft;
		location = new Point(269, 156);
		((Control)obj7).Location = location;
		((Control)lblAsiasoft).Name = "lblAsiasoft";
		LinkLabel obj8 = lblAsiasoft;
		size = new Size(210, 13);
		((Control)obj8).Size = size;
		((Control)lblAsiasoft).TabIndex = 4;
		((Label)lblAsiasoft).TabStop = true;
		lblAsiasoft.Text = "Công ty Cổ phần Phát triển Phần mềm Asia";
		Label4.AutoSize = true;
		((Control)Label4).BackColor = Color.Transparent;
		((Control)Label4).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = Color.Black;
		Label label3 = Label4;
		location = new Point(133, 156);
		((Control)label3).Location = location;
		((Control)Label4).Name = "Label4";
		Label label4 = Label4;
		size = new Size(135, 13);
		((Control)label4).Size = size;
		((Control)Label4).TabIndex = 3;
		Label4.Text = "Mọi chi tiết vui lòng liên hệ ";
		((Control)GroupBox1).ForeColor = Color.Silver;
		GroupBox groupBox = GroupBox1;
		location = new Point(31, 178);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(476, 2);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 24;
		GroupBox1.TabStop = false;
		((ButtonBase)cmdExit).Image = (Image)componentResourceManager.GetObject("cmdExit.Image");
		((ButtonBase)cmdExit).ImageAlign = (ContentAlignment)16;
		Button obj9 = cmdExit;
		location = new Point(116, 190);
		((Control)obj9).Location = location;
		((Control)cmdExit).Name = "cmdExit";
		Button obj10 = cmdExit;
		size = new Size(85, 25);
		((Control)obj10).Size = size;
		((Control)cmdExit).TabIndex = 2;
		((ButtonBase)cmdExit).Text = "Hủy";
		((ButtonBase)cmdExit).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdExit).UseVisualStyleBackColor = true;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.Transparent;
		((Control)Label1).ForeColor = Color.DarkGray;
		Label label5 = Label1;
		location = new Point(11, 170);
		((Control)label5).Location = location;
		((Control)Label1).Name = "Label1";
		Label label6 = Label1;
		size = new Size(44, 13);
		((Control)label6).Size = size;
		((Control)Label1).TabIndex = 20;
		Label1.Text = "Asiasoft";
		Label1.TextAlign = (ContentAlignment)32;
		((ButtonBase)cmdRegister).Image = (Image)componentResourceManager.GetObject("cmdRegister.Image");
		((ButtonBase)cmdRegister).ImageAlign = (ContentAlignment)16;
		Button obj11 = cmdRegister;
		location = new Point(25, 190);
		((Control)obj11).Location = location;
		((Control)cmdRegister).Name = "cmdRegister";
		Button obj12 = cmdRegister;
		size = new Size(85, 25);
		((Control)obj12).Size = size;
		((Control)cmdRegister).TabIndex = 1;
		((ButtonBase)cmdRegister).Text = "Đăng ký";
		((ButtonBase)cmdRegister).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdRegister).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(504, 226);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)lblAsiasoft);
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)cmdExit);
		((Control)this).Controls.Add((Control)(object)cmdRegister);
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "frmRegister";
		((Form)this).Text = "Đăng ký chương trình";
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmRegister_Load(object sender, EventArgs e)
	{
	}

	private void cmdRegister_Click(object sender, EventArgs e)
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		((Control)lblError).Visible = false;
		if (!File.Exists(txtSerialNumber.Text.Trim()))
		{
			lblError.Text = "File bản quyền không tồn tại.";
			((Control)lblError).Visible = true;
		}
		else if (ReadLicenceFile(txtSerialNumber.Text.Trim()))
		{
			if (Operators.ConditionalCompareObjectEqual((object)f_sSerialNumber, Encrypt(f_sUserName), false))
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software", writable: true);
				registryKey = registryKey.CreateSubKey(RegSubKeyName);
				registryKey.SetValue("UserName", f_sUserName);
				registryKey.SetValue("ProductKey", f_sSerialNumber);
				registryKey.Close();
				((Control)lblError).Visible = false;
				ActivateSuccess = true;
				CMessageBox.Show("Đăng ký thành công", SystemInformations.ProductFullName);
				((Component)(object)this).Dispose();
			}
			else
			{
				lblError.Text = "Thông tin đăng ký không hợp lệ.";
				((Control)lblError).Visible = true;
			}
		}
		else
		{
			lblError.Text = "Thông tin đăng ký không hợp lệ.";
			((Control)lblError).Visible = true;
		}
	}

	private void cmdExit_Click(object sender, EventArgs e)
	{
		((Component)(object)this).Dispose();
	}

	private void lblAsiasoft_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.asiasoft.com.vn");
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		Process.Start("http://www.asiasoft.com.vn");
	}

	private void cmdFile_Click(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		((Control)lblError).Visible = false;
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).Filter = "Licence File(*.asialic)|*.asialic";
		val.Multiselect = false;
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			txtSerialNumber.Text = ((FileDialog)val).FileName;
		}
	}

	private bool ReadLicenceFile(string file)
	{
		StreamReader streamReader = new StreamReader(file);
		string text = streamReader.ReadToEnd();
		int num = text.IndexOf("_");
		int num2 = text.LastIndexOf("_");
		if (num == -1 || num2 == -1)
		{
			return false;
		}
		f_sSerialNumber = checked(text.Substring(num + 1, num2 - num - 1));
		num = text.IndexOf(";");
		num2 = text.LastIndexOf(";");
		if (num == -1 || num2 == -1)
		{
			return false;
		}
		f_sUserName = checked(text.Substring(num + 1, num2 - num - 1));
		return true;
	}

	public object Encrypt(string text)
	{
		Helper.Symmetric symmetric = new Helper.Symmetric(Helper.Symmetric.Provider.Rijndael);
		Helper.CryptographyData cryptographyData = symmetric.Encrypt(new Helper.CryptographyData(text), KEY);
		return cryptographyData.ToHex();
	}
}
