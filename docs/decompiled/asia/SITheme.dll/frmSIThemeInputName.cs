using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class frmSIThemeInputName : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtName")]
	private TextBox _txtName;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("epNotice")]
	private ErrorProvider _epNotice;

	internal bool isOk;

	internal string f_sName;

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

	internal virtual TextBox txtName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtName = value;
		}
	}

	internal virtual Button cmdOk
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOk_Click;
			if (_cmdOk != null)
			{
				((Control)_cmdOk).Click -= eventHandler;
			}
			_cmdOk = value;
			if (_cmdOk != null)
			{
				((Control)_cmdOk).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdCancel
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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

	internal virtual ErrorProvider epNotice
	{
		[DebuggerNonUserCode]
		get
		{
			return _epNotice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_epNotice = value;
		}
	}

	public frmSIThemeInputName()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmSIThemeInputName_KeyDown);
		__ENCAddToList(this);
		isOk = false;
		f_sName = "";
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
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		components = new Container();
		Label1 = new Label();
		txtName = new TextBox();
		cmdOk = new Button();
		cmdCancel = new Button();
		epNotice = new ErrorProvider(components);
		((ISupportInitialize)epNotice).BeginInit();
		((Control)this).SuspendLayout();
		Label1.AutoSize = true;
		Label label = Label1;
		Point location = new Point(12, 16);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		Size size = new Size(26, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 0;
		Label1.Text = "Tên";
		TextBox obj = txtName;
		location = new Point(60, 13);
		((Control)obj).Location = location;
		((Control)txtName).Name = "txtName";
		TextBox obj2 = txtName;
		size = new Size(227, 20);
		((Control)obj2).Size = size;
		((Control)txtName).TabIndex = 1;
		Button obj3 = cmdOk;
		location = new Point(74, 47);
		((Control)obj3).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		Button obj4 = cmdOk;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)cmdOk).TabIndex = 2;
		((ButtonBase)cmdOk).Text = "Nhận";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = true;
		Button obj5 = cmdCancel;
		location = new Point(173, 47);
		((Control)obj5).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj6 = cmdCancel;
		size = new Size(75, 23);
		((Control)obj6).Size = size;
		((Control)cmdCancel).TabIndex = 3;
		((ButtonBase)cmdCancel).Text = "Hủy";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = true;
		epNotice.ContainerControl = (ContainerControl)(object)this;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(317, 82);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)txtName);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Name = "frmSIThemeInputName";
		((ISupportInitialize)epNotice).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdOk_Click(object sender, EventArgs e)
	{
		f_sName = txtName.Text.Trim();
		if (Operators.CompareString(f_sName, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtName, "Không để trống !");
			return;
		}
		epNotice.Clear();
		isOk = true;
		((Component)(object)this).Dispose();
	}

	private void frmSIThemeInputName_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Component)(object)this).Dispose();
		}
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		isOk = false;
		((Component)(object)this).Dispose();
	}
}
