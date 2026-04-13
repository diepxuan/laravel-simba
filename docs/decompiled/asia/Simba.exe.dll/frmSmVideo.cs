using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class frmSmVideo : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lstVideo")]
	private ListView _lstVideo;

	[AccessedThroughProperty("colStt")]
	private ColumnHeader _colStt;

	[AccessedThroughProperty("colVideo")]
	private ColumnHeader _colVideo;

	[AccessedThroughProperty("cmdPlay")]
	private Button _cmdPlay;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	internal virtual ListView lstVideo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstVideo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lstVideo = value;
		}
	}

	internal virtual ColumnHeader colStt
	{
		[DebuggerNonUserCode]
		get
		{
			return _colStt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_colStt = value;
		}
	}

	internal virtual ColumnHeader colVideo
	{
		[DebuggerNonUserCode]
		get
		{
			return _colVideo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_colVideo = value;
		}
	}

	protected virtual Button cmdPlay
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdPlay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdPlay_Click;
			if (_cmdPlay != null)
			{
				((Control)_cmdPlay).Click -= eventHandler;
			}
			_cmdPlay = value;
			if (_cmdPlay != null)
			{
				((Control)_cmdPlay).Click += eventHandler;
			}
		}
	}

	protected internal virtual Button cmdClose
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmdClose = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSmVideo()
	{
		((Form)this).Load += frmSmVideo_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
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
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSmVideo));
		lstVideo = new ListView();
		colStt = new ColumnHeader();
		colVideo = new ColumnHeader();
		cmdPlay = new Button();
		cmdClose = new Button();
		((Control)this).SuspendLayout();
		lstVideo.Columns.AddRange((ColumnHeader[])(object)new ColumnHeader[2] { colStt, colVideo });
		lstVideo.FullRowSelect = true;
		lstVideo.GridLines = true;
		ListView obj = lstVideo;
		Point location = new Point(12, 12);
		((Control)obj).Location = location;
		((Control)lstVideo).Name = "lstVideo";
		ListView obj2 = lstVideo;
		Size size = new Size(528, 409);
		((Control)obj2).Size = size;
		((Control)lstVideo).TabIndex = 4;
		lstVideo.UseCompatibleStateImageBehavior = false;
		lstVideo.View = (View)1;
		colStt.Text = "STT";
		colStt.Width = 41;
		colVideo.Text = "Video";
		colVideo.Width = 456;
		((Control)cmdPlay).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdPlay).Image = (Image)componentResourceManager.GetObject("cmdPlay.Image");
		((ButtonBase)cmdPlay).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdPlay).ImeMode = (ImeMode)0;
		Button obj3 = cmdPlay;
		location = new Point(12, 427);
		((Control)obj3).Location = location;
		((Control)cmdPlay).Name = "cmdPlay";
		Button obj4 = cmdPlay;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)cmdPlay).TabIndex = 5;
		((ButtonBase)cmdPlay).Text = "&Play";
		((ButtonBase)cmdPlay).TextAlign = (ContentAlignment)64;
		((Control)cmdClose).Anchor = (AnchorStyles)10;
		cmdClose.DialogResult = (DialogResult)2;
		((ButtonBase)cmdClose).Image = (Image)componentResourceManager.GetObject("cmdClose.Image");
		((ButtonBase)cmdClose).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdClose).ImeMode = (ImeMode)0;
		Button obj5 = cmdClose;
		location = new Point(93, 427);
		((Control)obj5).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdClose;
		size = new Size(65, 23);
		((Control)obj6).Size = size;
		((Control)cmdClose).TabIndex = 6;
		((ButtonBase)cmdClose).Text = "&Quay ra";
		((ButtonBase)cmdClose).TextAlign = (ContentAlignment)64;
		((Form)this).AcceptButton = (IButtonControl)(object)cmdPlay;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdClose;
		size = new Size(552, 462);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)lstVideo);
		((Control)this).Controls.Add((Control)(object)cmdPlay);
		((Control)this).Controls.Add((Control)(object)cmdClose);
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmSmVideo";
		((Form)this).Text = "Help Video";
		((Control)this).ResumeLayout(false);
	}

	private void cmdPlay_Click(object sender, EventArgs e)
	{
		if ((lstVideo.Items.Count > 0 && lstVideo.SelectedItems != null) ? true : false)
		{
			string text = SystemInformations.VideoHelpPath + lstVideo.SelectedItems[0].SubItems[2].Text;
			if (File.Exists(text))
			{
				Process.Start(text);
			}
		}
	}

	private void LoadData()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		string[] array = new string[3];
		IDataReader sYSDBDataReader = Commons.GetSYSDBDataReader("asGetVideoInfo");
		while (sYSDBDataReader.Read())
		{
			array[0] = Conversions.ToString(sYSDBDataReader["stt"]);
			array[1] = Conversions.ToString(sYSDBDataReader["ten_video"]);
			array[2] = Conversions.ToString(sYSDBDataReader["ten_file"]);
			ListViewItem val = new ListViewItem(array);
			lstVideo.Items.Add(val);
			val.Selected = true;
		}
		sYSDBDataReader.Close();
		if (lstVideo.Items.Count > 0)
		{
			lstVideo.Items[0].Selected = true;
		}
	}

	private void frmSmVideo_Load(object sender, EventArgs e)
	{
		LoadData();
	}
}
