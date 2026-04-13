using System.Diagnostics;
using System.Web;
using System.Web.Caching;

namespace DTE.Bussiness;

public class CacheSample
{
	public HttpRuntime _httpRuntime;

	public Cache Cache
	{
		get
		{
			EnsureHttpRuntime();
			return HttpRuntime.Cache;
		}
	}

	[DebuggerNonUserCode]
	public CacheSample()
	{
	}

	private void EnsureHttpRuntime()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (_httpRuntime == null)
		{
			try
			{
				_httpRuntime = new HttpRuntime();
			}
			finally
			{
			}
		}
	}
}
