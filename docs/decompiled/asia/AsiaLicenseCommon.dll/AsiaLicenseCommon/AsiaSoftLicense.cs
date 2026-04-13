using System.Diagnostics;
using System.IO;

namespace AsiaLicenseCommon;

public class AsiaSoftLicense
{
	public string LicenseTerms
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public string Signature
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	[DebuggerNonUserCode]
	public AsiaSoftLicense()
	{
	}

	public void Save(string filename)
	{
		Serializer.Save(this, filename);
	}

	public static AsiaSoftLicense Load(string filename)
	{
		return Serializer.Load<AsiaSoftLicense>(new FileInfo(filename));
	}
}
