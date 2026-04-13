using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DesignerCategory("code")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[GeneratedCode("xsd", "2.0.50727.42")]
[DebuggerStepThrough]
public class SeriesGroupingsType
{
	private SeriesGroupingType[] seriesGroupingField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("SeriesGrouping")]
	public SeriesGroupingType[] SeriesGrouping
	{
		get
		{
			return seriesGroupingField;
		}
		set
		{
			seriesGroupingField = value;
		}
	}

	[XmlAnyAttribute]
	public XmlAttribute[] AnyAttr
	{
		get
		{
			return anyAttrField;
		}
		set
		{
			anyAttrField = value;
		}
	}
}
