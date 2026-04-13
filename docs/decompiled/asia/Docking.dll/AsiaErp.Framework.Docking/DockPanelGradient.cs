using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AsiaErp.Framework.Docking;

[TypeConverter(typeof(DockPanelGradientConverter))]
public class DockPanelGradient
{
	private Color m_startColor;

	private Color m_endColor;

	private LinearGradientMode m_linearGradientMode;

	[DefaultValue(typeof(SystemColors), "Control")]
	public Color StartColor
	{
		get
		{
			return m_startColor;
		}
		set
		{
			m_startColor = value;
		}
	}

	[DefaultValue(typeof(SystemColors), "Control")]
	public Color EndColor
	{
		get
		{
			return m_endColor;
		}
		set
		{
			m_endColor = value;
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	public LinearGradientMode LinearGradientMode
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return m_linearGradientMode;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			m_linearGradientMode = value;
		}
	}

	public DockPanelGradient()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		m_startColor = SystemColors.Control;
		m_endColor = SystemColors.Control;
		m_linearGradientMode = (LinearGradientMode)0;
	}
}
