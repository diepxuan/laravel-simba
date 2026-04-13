using System.ComponentModel;
using System.Windows.Forms;

public class asPanel : Panel
{
	[DefaultValue(true)]
	public bool DoubleBuffered
	{
		get
		{
			return ((Control)this).DoubleBuffered;
		}
		set
		{
			((Control)this).DoubleBuffered = value;
		}
	}
}
