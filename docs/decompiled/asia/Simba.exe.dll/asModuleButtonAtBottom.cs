using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class asModuleButtonAtBottom : Button
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

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

	public asModuleButtonAtBottom()
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		__ENCAddToList(this);
		((ButtonBase)this).FlatStyle = (FlatStyle)0;
		((ButtonBase)this).FlatAppearance.BorderSize = 0;
		((ButtonBase)this).FlatAppearance.BorderColor = Color.Gray;
		((ButtonBase)this).FlatAppearance.MouseOverBackColor = Color.Transparent;
		((ButtonBase)this).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)this).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)this).AutoSize = false;
		((Control)this).Width = 33;
		((Control)this).Height = 33;
		Padding val = default(Padding);
		((Padding)(ref val))._002Ector(0);
		((Control)this).Padding = val;
		((Padding)(ref val))._002Ector(0);
		((Control)this).Margin = val;
	}

	protected override void OnMouseHover(EventArgs e)
	{
		((Control)this).OnMouseHover(e);
		((ButtonBase)this).FlatAppearance.BorderSize = 1;
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Button)this).OnMouseLeave(e);
		((ButtonBase)this).FlatAppearance.BorderSize = 0;
	}
}
