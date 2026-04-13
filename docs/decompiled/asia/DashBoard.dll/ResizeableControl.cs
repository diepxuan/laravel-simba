using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class ResizeableControl
{
	public enum CursorStatusEnum
	{
		None,
		Right,
		Left,
		Top,
		Bottom,
		TopLeft,
		BottomLeft,
		BottomRight
	}

	private bool mOnlyMove;

	private int mWidth;

	private bool isLeft;

	private bool mMouseDown;

	private CursorStatusEnum mCursorStatus;

	[AccessedThroughProperty("mControl")]
	private Control _mControl;

	private int minHeight;

	private int minWidth;

	private int maxWidth;

	private int minX;

	private int minY;

	private int maxX;

	private Point formLocation;

	private Point mouseLocation;

	private virtual Control mControl
	{
		get
		{
			return _mControl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(mControl_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(mControl_MouseUp);
			MouseEventHandler val3 = new MouseEventHandler(mControl_MouseDown);
			EventHandler eventHandler = mControl_MouseLeave;
			if (_mControl != null)
			{
				_mControl.MouseMove -= val;
				_mControl.MouseUp -= val2;
				_mControl.MouseDown -= val3;
				_mControl.MouseLeave -= eventHandler;
			}
			_mControl = value;
			if (_mControl != null)
			{
				_mControl.MouseMove += val;
				_mControl.MouseUp += val2;
				_mControl.MouseDown += val3;
				_mControl.MouseLeave += eventHandler;
			}
		}
	}

	public ResizeableControl(Control Control, bool OnlyMove = false)
	{
		mOnlyMove = false;
		mWidth = 10;
		isLeft = false;
		mMouseDown = false;
		mCursorStatus = CursorStatusEnum.None;
		minHeight = 30;
		minWidth = 200;
		minX = 10;
		minY = 10;
		formLocation = default(Point);
		mouseLocation = default(Point);
		mControl = Control;
		mOnlyMove = OnlyMove;
	}

	public Point GetLocation(int type)
	{
		Point point = default(Point);
		return type switch
		{
			1 => formLocation, 
			2 => mouseLocation, 
			_ => point, 
		};
	}

	public int GetCursorStatusEnum()
	{
		return (int)mCursorStatus;
	}

	public bool GetMouseStyle()
	{
		return isLeft;
	}

	private void mControl_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576)
		{
			isLeft = true;
			mMouseDown = true;
			mouseLocation = e.Location;
			formLocation = mControl.Parent.Location;
			mControl.Parent.BringToFront();
		}
		else
		{
			isLeft = false;
		}
	}

	private void mControl_MouseUp(object sender, MouseEventArgs e)
	{
		mMouseDown = false;
	}

	private void mControl_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		Control val = (Control)sender;
		Graphics val2 = val.CreateGraphics();
		checked
		{
			if (mOnlyMove)
			{
				if (mMouseDown & (mCursorStatus != CursorStatusEnum.None))
				{
					if (mCursorStatus == CursorStatusEnum.TopLeft)
					{
						int num = e.X - mouseLocation.X;
						int num2 = e.Y - mouseLocation.Y;
						val.Parent.SetBounds(val.Parent.Left + num, val.Parent.Top + num2, val.Parent.Width, val.Parent.Height);
					}
				}
				else
				{
					val.Cursor = Cursors.SizeAll;
					mCursorStatus = CursorStatusEnum.TopLeft;
				}
			}
			else if (mMouseDown & (mCursorStatus != CursorStatusEnum.None))
			{
				val.SuspendLayout();
				switch (mCursorStatus)
				{
				case CursorStatusEnum.BottomLeft:
					if (val.Width - e.X > minWidth)
					{
						val.SetBounds(val.Left + e.X, val.Top, val.Width - e.X, val.Height);
					}
					else
					{
						val.SetBounds(val.Left, val.Top, minWidth, val.Height);
					}
					if (val.Height - e.Y > 0)
					{
						if (val.Height > minHeight)
						{
							val.SetBounds(val.Left, val.Top, val.Width, val.Height - (val.Height - e.Y));
						}
					}
					else
					{
						val.SetBounds(val.Left, val.Top, val.Width, val.Height - (val.Height - e.Y));
					}
					break;
				case CursorStatusEnum.BottomRight:
					if (val.Width - e.X > 0)
					{
						if (val.Width > minWidth)
						{
							val.SetBounds(val.Left, val.Top, val.Width - (val.Width - e.X), val.Height);
						}
					}
					else
					{
						val.SetBounds(val.Left, val.Top, val.Width - (val.Width - e.X), val.Height);
					}
					if (val.Height - e.Y > 0)
					{
						if (val.Height > minHeight)
						{
							val.SetBounds(val.Left, val.Top, val.Width, val.Height - (val.Height - e.Y));
						}
					}
					else
					{
						val.SetBounds(val.Left, val.Top, val.Width, val.Height - (val.Height - e.Y));
					}
					break;
				case CursorStatusEnum.Left:
					if (val.Width - e.X > minWidth)
					{
						val.SetBounds(val.Left + e.X, val.Top, val.Width - e.X, val.Height);
					}
					else
					{
						val.SetBounds(val.Left, val.Top, minWidth, val.Height);
					}
					break;
				case CursorStatusEnum.Right:
					if (val.Width - e.X > 0)
					{
						if (val.Width > minWidth)
						{
							val.SetBounds(val.Left, val.Top, val.Width - (val.Width - e.X), val.Height);
						}
					}
					else
					{
						val.SetBounds(val.Left, val.Top, val.Width - (val.Width - e.X), val.Height);
					}
					break;
				case CursorStatusEnum.Bottom:
					if (val.Height - e.Y > 0)
					{
						if (val.Height > minHeight)
						{
							val.SetBounds(val.Left, val.Top, val.Width, val.Height - (val.Height - e.Y));
						}
					}
					else
					{
						val.SetBounds(val.Left, val.Top, val.Width, val.Height - (val.Height - e.Y));
					}
					break;
				}
				val.ResumeLayout();
			}
			else
			{
				SetCursorStatus(val, e);
			}
		}
	}

	private void mControl_MouseLeave(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		Control val = (Control)sender;
		mCursorStatus = CursorStatusEnum.None;
		val.Cursor = Cursors.Default;
		val.Refresh();
	}

	private void SetCursorStatus(Control c, MouseEventArgs e)
	{
		bool flag = true;
		checked
		{
			if (flag == ((e.X <= c.Width) & (e.Y <= 24)))
			{
				c.Cursor = Cursors.SizeAll;
				mCursorStatus = CursorStatusEnum.TopLeft;
			}
			else if (flag == ((e.X < mWidth) & (e.Y > c.Height - mWidth)))
			{
				c.Cursor = Cursors.SizeNESW;
				mCursorStatus = CursorStatusEnum.BottomLeft;
			}
			else if (flag == ((e.X > c.Width - mWidth) & (e.Y > c.Height - mWidth)))
			{
				c.Cursor = Cursors.SizeNWSE;
				mCursorStatus = CursorStatusEnum.BottomRight;
			}
			else if (flag == e.X <= mWidth)
			{
				c.Cursor = Cursors.SizeWE;
				mCursorStatus = CursorStatusEnum.Left;
			}
			else if (flag == e.X > c.Width - mWidth)
			{
				c.Cursor = Cursors.SizeWE;
				mCursorStatus = CursorStatusEnum.Right;
			}
			else if (flag == e.Y <= mWidth)
			{
				c.Cursor = Cursors.SizeNS;
				mCursorStatus = CursorStatusEnum.Top;
			}
			else if (flag == e.Y > c.Height - mWidth)
			{
				c.Cursor = Cursors.SizeNS;
				mCursorStatus = CursorStatusEnum.Bottom;
			}
			else
			{
				c.Cursor = Cursors.Default;
				mCursorStatus = CursorStatusEnum.None;
			}
		}
	}
}
