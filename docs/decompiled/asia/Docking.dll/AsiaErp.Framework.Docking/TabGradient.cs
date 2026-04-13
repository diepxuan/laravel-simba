using System.ComponentModel;
using System.Drawing;

namespace AsiaErp.Framework.Docking;

[TypeConverter(typeof(DockPaneTabGradientConverter))]
public class TabGradient : DockPanelGradient
{
	private Color m_textColor;

	[DefaultValue(typeof(SystemColors), "ControlText")]
	public Color TextColor
	{
		get
		{
			return m_textColor;
		}
		set
		{
			m_textColor = value;
		}
	}

	public TabGradient()
	{
		m_textColor = SystemColors.ControlText;
	}
}
