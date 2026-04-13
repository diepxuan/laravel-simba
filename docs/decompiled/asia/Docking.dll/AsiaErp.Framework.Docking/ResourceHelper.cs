using System.Resources;

namespace AsiaErp.Framework.Docking;

internal static class ResourceHelper
{
	private static ResourceManager _resourceManager;

	private static ResourceManager ResourceManager
	{
		get
		{
			if (_resourceManager == null)
			{
				_resourceManager = new ResourceManager("AsiaErp.Framework.Docking.Strings", typeof(ResourceHelper).Assembly);
			}
			return _resourceManager;
		}
	}

	public static string GetString(string name)
	{
		return ResourceManager.GetString(name);
	}
}
