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
public class OpenListBoxColors : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ColoredListBox1")]
	private AsListBoxColors _ColoredListBox1;

	public Color color_;

	public bool isOke;

	internal virtual AsListBoxColors ColoredListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColoredListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(ColoredListBox1_KeyDown);
			EventHandler eventHandler = ColoredListBox1_DoubleClick;
			if (_ColoredListBox1 != null)
			{
				((Control)_ColoredListBox1).KeyDown -= val;
				((Control)_ColoredListBox1).DoubleClick -= eventHandler;
			}
			_ColoredListBox1 = value;
			if (_ColoredListBox1 != null)
			{
				((Control)_ColoredListBox1).KeyDown += val;
				((Control)_ColoredListBox1).DoubleClick += eventHandler;
			}
		}
	}

	public OpenListBoxColors()
	{
		((Form)this).Load += OpenListBoxColors_Load;
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		isOke = false;
		InitializeComponent();
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
		ColoredListBox1 = new AsListBoxColors();
		((Control)this).SuspendLayout();
		((ListBox)ColoredListBox1).BorderStyle = (BorderStyle)0;
		ColoredListBox1.ColorBarWidth = 30;
		((Control)ColoredListBox1).Dock = (DockStyle)5;
		((ListBox)ColoredListBox1).DrawMode = (DrawMode)1;
		((ListControl)ColoredListBox1).FormattingEnabled = true;
		AsListBoxColors coloredListBox = ColoredListBox1;
		Point location = new Point(0, 0);
		((Control)coloredListBox).Location = location;
		((Control)ColoredListBox1).Name = "ColoredListBox1";
		AsListBoxColors coloredListBox2 = ColoredListBox1;
		Size size = new Size(171, 221);
		((Control)coloredListBox2).Size = size;
		((Control)ColoredListBox1).TabIndex = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(171, 227);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)ColoredListBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "OpenListBoxColors";
		((Form)this).StartPosition = (FormStartPosition)0;
		((Form)this).Text = "OpenListBoxColors";
		((Control)this).ResumeLayout(false);
	}

	private void OpenListBoxColors_Load(object sender, EventArgs e)
	{
		try
		{
			AsListBoxColors coloredListBox = ColoredListBox1;
			coloredListBox.AddKnownColors();
			coloredListBox = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void ColoredListBox1_DoubleClick(object sender, EventArgs e)
	{
		color_ = ColoredListBox1.SelectedColor;
		isOke = true;
		((Component)(object)this).Dispose();
	}

	private void ColoredListBox1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 13)
		{
			color_ = ColoredListBox1.SelectedColor;
			isOke = true;
			((Component)(object)this).Dispose();
		}
		else if ((int)e.KeyCode == 27)
		{
			isOke = false;
			((Component)(object)this).Dispose();
		}
	}
}
