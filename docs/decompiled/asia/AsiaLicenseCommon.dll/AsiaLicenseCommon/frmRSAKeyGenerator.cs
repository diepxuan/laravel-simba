using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaLicenseCommon;

[DesignerGenerated]
public class frmRSAKeyGenerator : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("btGenerate")]
	private Button _btGenerate;

	[AccessedThroughProperty("txtPrivateKey")]
	private TextBox _txtPrivateKey;

	[AccessedThroughProperty("txtPublicKey")]
	private TextBox _txtPublicKey;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	internal virtual Button btGenerate
	{
		[DebuggerNonUserCode]
		get
		{
			return _btGenerate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btGenerate_Click;
			if (_btGenerate != null)
			{
				((Control)_btGenerate).Click -= eventHandler;
			}
			_btGenerate = value;
			if (_btGenerate != null)
			{
				((Control)_btGenerate).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox txtPrivateKey
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPrivateKey;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPrivateKey = value;
		}
	}

	internal virtual TextBox txtPublicKey
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPublicKey;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPublicKey = value;
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

	[DebuggerNonUserCode]
	public frmRSAKeyGenerator()
	{
		__ENCAddToList(this);
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
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		btGenerate = new Button();
		txtPrivateKey = new TextBox();
		txtPublicKey = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		((Control)this).SuspendLayout();
		Button obj = btGenerate;
		Point location = new Point(15, 503);
		((Control)obj).Location = location;
		((Control)btGenerate).Name = "btGenerate";
		Button obj2 = btGenerate;
		Size size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)btGenerate).TabIndex = 0;
		((ButtonBase)btGenerate).Text = "Generate";
		((ButtonBase)btGenerate).UseVisualStyleBackColor = true;
		TextBox obj3 = txtPrivateKey;
		location = new Point(15, 282);
		((Control)obj3).Location = location;
		txtPrivateKey.Multiline = true;
		((Control)txtPrivateKey).Name = "txtPrivateKey";
		TextBox obj4 = txtPrivateKey;
		size = new Size(967, 184);
		((Control)obj4).Size = size;
		((Control)txtPrivateKey).TabIndex = 1;
		TextBox obj5 = txtPublicKey;
		location = new Point(15, 35);
		((Control)obj5).Location = location;
		txtPublicKey.Multiline = true;
		((Control)txtPublicKey).Name = "txtPublicKey";
		TextBox obj6 = txtPublicKey;
		size = new Size(967, 184);
		((Control)obj6).Size = size;
		((Control)txtPublicKey).TabIndex = 2;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(12, 9);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(74, 17);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 3;
		Label1.Text = "Public Key";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(12, 262);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(80, 17);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 4;
		Label2.Text = "Private Key";
		SizeF autoScaleDimensions = new SizeF(8f, 16f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(1007, 538);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)txtPublicKey);
		((Control)this).Controls.Add((Control)(object)txtPrivateKey);
		((Control)this).Controls.Add((Control)(object)btGenerate);
		((Control)this).Name = "frmRSAKeyGenerator";
		((Form)this).Text = "frmRSAKeyGenerator";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void btGenerate_Click(object sender, EventArgs e)
	{
		DSACryptoServiceProvider dSACryptoServiceProvider = new DSACryptoServiceProvider();
		txtPublicKey.Text = dSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
		txtPrivateKey.Text = dSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
	}
}
