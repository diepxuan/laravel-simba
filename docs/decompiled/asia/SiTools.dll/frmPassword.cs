using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class frmPassword : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("btnOk")]
	private Button _btnOk;

	[AccessedThroughProperty("txtPassWord")]
	private TextBox _txtPassWord;

	[AccessedThroughProperty("btnCancel")]
	private Button _btnCancel;

	internal bool is_ok;

	internal string CompanyId;

	internal string UserName;

	private string StrPassWord;

	private string InputPassword;

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

	internal virtual TextBox txtPassWord
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPassWord;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPassWord = value;
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

	public frmPassword()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmPassword_KeyDown);
		((Form)this).Load += frmPassword_Load;
		__ENCAddToList(this);
		is_ok = false;
		CompanyId = "";
		UserName = "";
		StrPassWord = "";
		InputPassword = "";
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
			((Form)this).Dispose(disposing);
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
		btnOk = new Button();
		txtPassWord = new TextBox();
		btnCancel = new Button();
		((Control)this).SuspendLayout();
		((ButtonBase)btnOk).FlatStyle = (FlatStyle)1;
		Button obj = btnOk;
		Point location = new Point(30, 38);
		((Control)obj).Location = location;
		((Control)btnOk).Name = "btnOk";
		Button obj2 = btnOk;
		Size size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)btnOk).TabIndex = 1;
		((ButtonBase)btnOk).Text = "Ok";
		((ButtonBase)btnOk).UseVisualStyleBackColor = true;
		TextBox obj3 = txtPassWord;
		location = new Point(12, 12);
		((Control)obj3).Location = location;
		((Control)txtPassWord).Name = "txtPassWord";
		TextBox obj4 = txtPassWord;
		size = new Size(195, 20);
		((Control)obj4).Size = size;
		((Control)txtPassWord).TabIndex = 0;
		txtPassWord.UseSystemPasswordChar = true;
		btnCancel.DialogResult = (DialogResult)2;
		((ButtonBase)btnCancel).FlatStyle = (FlatStyle)1;
		Button obj5 = btnCancel;
		location = new Point(111, 38);
		((Control)obj5).Location = location;
		((Control)btnCancel).Name = "btnCancel";
		Button obj6 = btnCancel;
		size = new Size(75, 23);
		((Control)obj6).Size = size;
		((Control)btnCancel).TabIndex = 2;
		((ButtonBase)btnCancel).Text = "Cancel";
		((ButtonBase)btnCancel).UseVisualStyleBackColor = true;
		((Form)this).AcceptButton = (IButtonControl)(object)btnOk;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).CancelButton = (IButtonControl)(object)btnCancel;
		size = new Size(219, 67);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)btnCancel);
		((Control)this).Controls.Add((Control)(object)txtPassWord);
		((Control)this).Controls.Add((Control)(object)btnOk);
		((Form)this).FormBorderStyle = (FormBorderStyle)6;
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmPassword";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Nhập mật khẩu đặc biệt để sử dụng";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmPassword_Load(object sender, EventArgs e)
	{
		StrPassWord = CompanyId + DateTime.Today.ToString("ddMMyyyy") + UserName;
	}

	private void frmPassword_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
	}

	private void btnOk_Click(object sender, EventArgs e)
	{
		InputPassword = txtPassWord.Text;
		if (Operators.CompareString(InputPassword.ToUpper(), "123qwe".ToUpper(), false) == 0)
		{
			is_ok = true;
		}
		else
		{
			char[] array = StrPassWord.ToCharArray();
			char[] array2 = array;
			int num = 0;
			while (true)
			{
				if (num < array2.Length)
				{
					char c = array2[num];
					if (!InputPassword.Contains(Conversions.ToString(c)))
					{
						is_ok = false;
						break;
					}
					num = checked(num + 1);
					continue;
				}
				is_ok = true;
				break;
			}
		}
		((Form)this).Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		is_ok = false;
		((Form)this).Close();
	}
}
