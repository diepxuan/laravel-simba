using System.Diagnostics;

namespace AsiaErp.UserInterface;

internal class lstVoucherInfo
{
	public string ma_ct
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public string ten_ct
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public lstVoucherInfo()
	{
	}

	public lstVoucherInfo(string ma, string ten)
	{
		ma_ct = ma;
		ten_ct = ten;
	}
}
