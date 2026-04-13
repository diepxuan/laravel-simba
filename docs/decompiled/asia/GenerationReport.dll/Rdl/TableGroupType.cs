using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[GeneratedCode("xsd", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class TableGroupType
{
	private object[] itemsField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Visibility", typeof(VisibilityType))]
	[XmlElement("Header", typeof(HeaderType))]
	[XmlElement("Sorting", typeof(SortingType))]
	[XmlAnyElement]
	[XmlElement("Footer", typeof(FooterType))]
	[XmlElement("Grouping", typeof(GroupingType))]
	public object[] Items
	{
		get
		{
			return itemsField;
		}
		set
		{
			itemsField = value;
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
