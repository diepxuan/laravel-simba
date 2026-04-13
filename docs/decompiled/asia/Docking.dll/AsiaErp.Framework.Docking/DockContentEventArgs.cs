using System;

namespace AsiaErp.Framework.Docking;

public class DockContentEventArgs : EventArgs
{
	private IDockContent m_content;

	public IDockContent Content => m_content;

	public DockContentEventArgs(IDockContent content)
	{
		m_content = content;
	}
}
