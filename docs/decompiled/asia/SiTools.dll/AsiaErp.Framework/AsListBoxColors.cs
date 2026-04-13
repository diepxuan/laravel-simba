using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.Framework;

public class AsListBoxColors : ListBox
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private int WidthOfColorBar;

	private int LastColorIndex;

	private Color[] colors;

	private string[] Strings;

	public Color SelectedColor
	{
		get
		{
			Color color = default(Color);
			try
			{
				color = GetColor(((ListBox)this).SelectedIndex);
				return color;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return color;
		}
	}

	public int ColorBarWidth
	{
		get
		{
			return WidthOfColorBar;
		}
		set
		{
			WidthOfColorBar = value;
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

	private Color GetColor(int Index)
	{
		return colors[Index];
	}

	public AsListBoxColors()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		((ListBox)this).DrawItem += new DrawItemEventHandler(ColoredComboBox_DrawItem);
		__ENCAddToList(this);
		colors = new Color[65536];
		Strings = new string[65536];
		LastColorIndex = 0;
		WidthOfColorBar = 30;
		((ListBox)this).DrawMode = (DrawMode)1;
	}

	public void AddKnownColors()
	{
		Color color = default(Color);
		Type typeFromHandle = typeof(Color);
		PropertyInfo[] properties = typeFromHandle.GetProperties();
		PropertyInfo[] array = properties;
		Color color3 = default(Color);
		foreach (PropertyInfo propertyInfo in array)
		{
			if ((object)propertyInfo.PropertyType == typeof(Color))
			{
				object? value = propertyInfo.GetValue(color, null);
				Color color2 = ((value != null) ? ((Color)value) : color3);
				AddItem(color2.Name, color2);
			}
		}
	}

	public void AddItem(string Item, Color Color)
	{
		colors[LastColorIndex] = Color;
		Strings[LastColorIndex] = Item;
		checked
		{
			LastColorIndex++;
			((ListBox)this).Items.Add((object)Item);
		}
	}

	private void ColoredComboBox_DrawItem(object sender, DrawItemEventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019c: Expected O, but got Unknown
		try
		{
			if (e.Index != -1)
			{
				string text = Strings[e.Index];
				Brush val = (Brush)new SolidBrush(GetColor(e.Index));
				Rectangle bounds = e.Bounds;
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.LightYellow), bounds);
				Color highlight = SystemColors.Highlight;
				Color color = default(Color);
				if (((int)e.State == 16) | ((int)e.State == 1) | ((int)e.State == 17))
				{
					e.Graphics.FillRectangle((Brush)new SolidBrush(Color.SkyBlue), e.Bounds);
				}
				else
				{
					Graphics graphics = e.Graphics;
					object obj = NewLateBinding.LateGet(sender, (Type)null, "BackColor", new object[0], (string[])null, (Type[])null, (bool[])null);
					graphics.FillRectangle((Brush)new SolidBrush((obj != null) ? ((Color)obj) : color), e.Bounds);
				}
				bounds.Width = WidthOfColorBar;
				checked
				{
					bounds.Height -= 4;
					bounds.X += 2;
					bounds.Y += 2;
					e.Graphics.FillRectangle(val, bounds);
					e.Graphics.DrawRectangle(Pens.Black, bounds);
					Graphics graphics2 = e.Graphics;
					Font val2 = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1);
					object obj2 = NewLateBinding.LateGet(sender, (Type)null, "forecolor", new object[0], (string[])null, (Type[])null, (bool[])null);
					graphics2.DrawString(text, val2, (Brush)new SolidBrush((obj2 != null) ? ((Color)obj2) : color), (float)(WidthOfColorBar + 5), (float)(bounds.Y - 2));
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
