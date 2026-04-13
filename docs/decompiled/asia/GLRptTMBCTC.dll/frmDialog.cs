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
public class frmDialog : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblCaption")]
	private Label _lblCaption;

	[AccessedThroughProperty("btnToan_bo")]
	private Button _btnToan_bo;

	[AccessedThroughProperty("btnHien_tai")]
	private Button _btnHien_tai;

	[AccessedThroughProperty("btnHuy")]
	private Button _btnHuy;

	[AccessedThroughProperty("ptbIcon")]
	private PictureBox _ptbIcon;

	internal string oAction;

	internal virtual Label lblCaption
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCaption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCaption = value;
		}
	}

	internal virtual Button btnToan_bo
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnToan_bo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnToan_bo_Click;
			if (_btnToan_bo != null)
			{
				((Control)_btnToan_bo).Click -= eventHandler;
			}
			_btnToan_bo = value;
			if (_btnToan_bo != null)
			{
				((Control)_btnToan_bo).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnHien_tai
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnHien_tai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnHien_tai_Click;
			if (_btnHien_tai != null)
			{
				((Control)_btnHien_tai).Click -= eventHandler;
			}
			_btnHien_tai = value;
			if (_btnHien_tai != null)
			{
				((Control)_btnHien_tai).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnHuy
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnHuy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnHuy_Click;
			if (_btnHuy != null)
			{
				((Control)_btnHuy).Click -= eventHandler;
			}
			_btnHuy = value;
			if (_btnHuy != null)
			{
				((Control)_btnHuy).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox ptbIcon
	{
		[DebuggerNonUserCode]
		get
		{
			return _ptbIcon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ptbIcon = value;
		}
	}

	public frmDialog()
	{
		((Form)this).Load += frmDialog_Load;
		__ENCAddToList(this);
		oAction = "2";
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
		lblCaption = new Label();
		btnToan_bo = new Button();
		btnHien_tai = new Button();
		btnHuy = new Button();
		ptbIcon = new PictureBox();
		((ISupportInitialize)ptbIcon).BeginInit();
		((Control)this).SuspendLayout();
		Label obj = lblCaption;
		Point location = new Point(68, 9);
		((Control)obj).Location = location;
		((Control)lblCaption).Name = "lblCaption";
		Label obj2 = lblCaption;
		Size size = new Size(307, 50);
		((Control)obj2).Size = size;
		((Control)lblCaption).TabIndex = 0;
		lblCaption.TextAlign = (ContentAlignment)32;
		Button obj3 = btnToan_bo;
		location = new Point(68, 61);
		((Control)obj3).Location = location;
		((Control)btnToan_bo).Name = "btnToan_bo";
		Button obj4 = btnToan_bo;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)btnToan_bo).TabIndex = 1;
		((ButtonBase)btnToan_bo).Text = "Tất &Cả";
		((ButtonBase)btnToan_bo).UseVisualStyleBackColor = true;
		Button obj5 = btnHien_tai;
		location = new Point(157, 61);
		((Control)obj5).Location = location;
		((Control)btnHien_tai).Name = "btnHien_tai";
		Button obj6 = btnHien_tai;
		size = new Size(75, 23);
		((Control)obj6).Size = size;
		((Control)btnHien_tai).TabIndex = 2;
		((ButtonBase)btnHien_tai).Text = "&Hiện Tại";
		((ButtonBase)btnHien_tai).UseVisualStyleBackColor = true;
		btnHuy.DialogResult = (DialogResult)2;
		Button obj7 = btnHuy;
		location = new Point(246, 61);
		((Control)obj7).Location = location;
		((Control)btnHuy).Name = "btnHuy";
		Button obj8 = btnHuy;
		size = new Size(75, 23);
		((Control)obj8).Size = size;
		((Control)btnHuy).TabIndex = 3;
		((ButtonBase)btnHuy).Text = "&Thoát";
		((ButtonBase)btnHuy).UseVisualStyleBackColor = true;
		((Control)ptbIcon).BackgroundImageLayout = (ImageLayout)2;
		PictureBox obj9 = ptbIcon;
		location = new Point(17, 18);
		((Control)obj9).Location = location;
		((Control)ptbIcon).Name = "ptbIcon";
		PictureBox obj10 = ptbIcon;
		size = new Size(32, 32);
		((Control)obj10).Size = size;
		ptbIcon.TabIndex = 4;
		ptbIcon.TabStop = false;
		((Form)this).AcceptButton = (IButtonControl)(object)btnToan_bo;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).CancelButton = (IButtonControl)(object)btnHuy;
		size = new Size(386, 95);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)ptbIcon);
		((Control)this).Controls.Add((Control)(object)btnHuy);
		((Control)this).Controls.Add((Control)(object)btnHien_tai);
		((Control)this).Controls.Add((Control)(object)btnToan_bo);
		((Control)this).Controls.Add((Control)(object)lblCaption);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmDialog";
		((Form)this).Text = "Thông báo";
		((ISupportInitialize)ptbIcon).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmDialog_Load(object sender, EventArgs e)
	{
		((Form)this).Text = SystemInformations.ProductFullName;
		lblCaption.Text = Helper.GetMess(50171).Description;
		ptbIcon.Image = (Image)(object)SystemIcons.Question.ToBitmap();
	}

	private void btnToan_bo_Click(object sender, EventArgs e)
	{
		oAction = "0";
		((Form)this).Close();
	}

	private void btnHien_tai_Click(object sender, EventArgs e)
	{
		oAction = "1";
		((Form)this).Close();
	}

	private void btnHuy_Click(object sender, EventArgs e)
	{
		oAction = "2";
		((Form)this).Close();
	}
}
