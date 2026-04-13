using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "2.0.50727.42")]
public class DetailsType
{
	private object[] itemsField;

	private XmlAttribute[] anyAttrField;

	[XmlAnyElement]
	[XmlElement("Sorting", typeof(SortingType))]
	[XmlElement("TableRows", typeof(TableRowsType))]
	[XmlElement("Visibility", typeof(VisibilityType))]
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
