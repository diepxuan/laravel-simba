using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AsiaErp.Framework.Docking;

internal static class DrawHelper
{
	public static Point RtlTransform(Control control, Point point)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)control.RightToLeft != 1)
		{
			return point;
		}
		return new Point(control.Right - point.X, point.Y);
	}

	public static Rectangle RtlTransform(Control control, Rectangle rectangle)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)control.RightToLeft != 1)
		{
			return rectangle;
		}
		return new Rectangle(control.ClientRectangle.Right - rectangle.Right, rectangle.Y, rectangle.Width, rectangle.Height);
	}

	public static GraphicsPath GetRoundedCornerTab(GraphicsPath graphicsPath, Rectangle rect, bool upCorner)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		if (graphicsPath == null)
		{
			graphicsPath = new GraphicsPath();
		}
		else
		{
			graphicsPath.Reset();
		}
		int num = 6;
		if (upCorner)
		{
			graphicsPath.AddLine(rect.Left, rect.Bottom, rect.Left, rect.Top + num / 2);
			graphicsPath.AddArc(new Rectangle(rect.Left, rect.Top, num, num), 180f, 90f);
			graphicsPath.AddLine(rect.Left + num / 2, rect.Top, rect.Right - num / 2, rect.Top);
			graphicsPath.AddArc(new Rectangle(rect.Right - num, rect.Top, num, num), -90f, 90f);
			graphicsPath.AddLine(rect.Right, rect.Top + num / 2, rect.Right, rect.Bottom);
		}
		else
		{
			graphicsPath.AddLine(rect.Right, rect.Top, rect.Right, rect.Bottom - num / 2);
			graphicsPath.AddArc(new Rectangle(rect.Right - num, rect.Bottom - num, num, num), 0f, 90f);
			graphicsPath.AddLine(rect.Right - num / 2, rect.Bottom, rect.Left + num / 2, rect.Bottom);
			graphicsPath.AddArc(new Rectangle(rect.Left, rect.Bottom - num, num, num), 90f, 90f);
			graphicsPath.AddLine(rect.Left, rect.Bottom - num / 2, rect.Left, rect.Top);
		}
		return graphicsPath;
	}

	public static GraphicsPath CalculateGraphicsPathFromBitmap(Bitmap bitmap)
	{
		return CalculateGraphicsPathFromBitmap(bitmap, Color.Empty);
	}

	public static GraphicsPath CalculateGraphicsPathFromBitmap(Bitmap bitmap, Color colorTransparent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		if (colorTransparent == Color.Empty)
		{
			colorTransparent = bitmap.GetPixel(0, 0);
		}
		for (int i = 0; i < ((Image)bitmap).Height; i++)
		{
			int num = 0;
			for (int j = 0; j < ((Image)bitmap).Width; j++)
			{
				if (bitmap.GetPixel(j, i) != colorTransparent)
				{
					num = j;
					int num2 = j;
					for (num2 = num; num2 < ((Image)bitmap).Width && !(bitmap.GetPixel(num2, i) == colorTransparent); num2++)
					{
					}
					val.AddRectangle(new Rectangle(num, i, num2 - num, 1));
					j = num2;
				}
			}
		}
		return val;
	}
}
