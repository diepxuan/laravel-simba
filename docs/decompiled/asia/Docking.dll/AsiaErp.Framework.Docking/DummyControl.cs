using System.Windows.Forms;

namespace AsiaErp.Framework.Docking;

internal class DummyControl : Control
{
	public DummyControl()
	{
		((Control)this).SetStyle((ControlStyles)512, false);
	}
}
