using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;

public class ReportInforConverter : ExpandableObjectConverter
{
	[DebuggerNonUserCode]
	public ReportInforConverter()
	{
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (((object)destinationType == typeof(string) && value == typeof(ReportInformation)) ? true : false)
		{
			return "abda";
		}
		return base.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
	}
}
