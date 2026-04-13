using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace AsiaErp.Framework.Docking;

internal abstract class InertButtonBase : Control
{
	private bool m_isMouseOver;

	public abstract Bitmap Image { get; }

	protected bool IsMouseOver
	{
		get
		{
			return m_isMouseOver;
		}
		private set
		{
			if (m_isMouseOver != value)
			{
				m_isMouseOver = value;
				((Control)this).Invalidate();
			}
		}
	}

	protected override Size DefaultSize => ((Image)Resources.DockPane_Close).Size;

	protected InertButtonBase()
	{
		((Control)this).SetStyle((ControlStyles)2048, true);
		((Control)this).BackColor = Color.Transparent;
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		bool flag = ((Control)this).ClientRectangle.Contains(e.X, e.Y);
		if (IsMouseOver != flag)
		{
			IsMouseOver = flag;
		}
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		((Control)this).OnMouseEnter(e);
		if (!IsMouseOver)
		{
			IsMouseOver = true;
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		if (IsMouseOver)
		{
			IsMouseOver = false;
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		if (IsMouseOver && ((Control)this).Enabled)
		{
			Pen val = new Pen(((Control)this).ForeColor);
			try
			{
				e.Graphics.DrawRectangle(val, Rectangle.Inflate(((Control)this).ClientRectangle, -1, -1));
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		ImageAttributes val2 = new ImageAttributes();
		try
		{
			ColorMap[] array = (ColorMap[])(object)new ColorMap[2]
			{
				new ColorMap(),
				default(ColorMap)
			};
			array[0].OldColor = Color.FromArgb(0, 0, 0);
			array[0].NewColor = ((Control)this).ForeColor;
			array[1] = new ColorMap();
			array[1].OldColor = Image.GetPixel(0, 0);
			array[1].NewColor = Color.Transparent;
			val2.SetRemapTable(array);
			e.Graphics.DrawImage((Image)(object)Image, new Rectangle(0, 0, ((Image)Image).Width, ((Image)Image).Height), 0, 0, ((Image)Image).Width, ((Image)Image).Height, (GraphicsUnit)2, val2);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		((Control)this).OnPaint(e);
	}

	public void RefreshChanges()
	{
		if (!((Control)this).IsDisposed)
		{
			bool flag = ((Control)this).ClientRectangle.Contains(((Control)this).PointToClient(Control.MousePosition));
			if (flag != IsMouseOver)
			{
				IsMouseOver = flag;
			}
			OnRefreshChanges();
		}
	}

	protected virtual void OnRefreshChanges()
	{
	}
}
