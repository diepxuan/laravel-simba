using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

public class ReporCollectionConverter : ExpandableObjectConverter
{
	[DebuggerNonUserCode]
	public ReporCollectionConverter()
	{
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (((object)destinationType == typeof(string) && value == typeof(ReportCollection)) ? true : false)
		{
			return "test";
		}
		return base.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
	}
}
