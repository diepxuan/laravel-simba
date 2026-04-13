using System;
using System.ComponentModel;
using System.Diagnostics;
using AsiaErp.Framework;

[Serializable]
public class MenuInformations
{
	[Description("Thông tin menu")]
	public MenuInformation MenuInformation
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	[Description("Thông tin menu drilldown")]
	public MenuDrillDownInformation MenuDrillDownInformation
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	[Description("Thông tin từ điển")]
	public DictionaryInformation DictionaryInformation
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	[Description("Thông tin truy cập cơ sở dữ liệu")]
	public DAOInformation DAOInformation
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	[Description("Thông tin tính toán")]
	public CalcInfo CalcInfo
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	[Description("Thông tin chứng từ")]
	public VoucherInformation VoucherInformation
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	[Description("Thông tin báo cáo")]
	[TypeConverter(typeof(ReporCollectionConverter))]
	public ReportCollection ReportInformation
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	[DebuggerNonUserCode]
	public MenuInformations()
	{
	}
}
