using System;
using System.ComponentModel;

namespace AsiaErp.Framework.Docking;

[AttributeUsage(AttributeTargets.All)]
internal sealed class LocalizedDescriptionAttribute : DescriptionAttribute
{
	private bool m_initialized;

	public override string Description
	{
		get
		{
			if (!m_initialized)
			{
				string description = base.Description;
				base.DescriptionValue = ResourceHelper.GetString(description);
				if (base.DescriptionValue == null)
				{
					base.DescriptionValue = string.Empty;
				}
				m_initialized = true;
			}
			return base.DescriptionValue;
		}
	}

	public LocalizedDescriptionAttribute(string key)
		: base(key)
	{
	}
}
