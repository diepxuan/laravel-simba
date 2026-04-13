using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[GeneratedCode("xsd", "2.0.50727.42")]
public class DynamicColumnsRowsType
{
	private object[] itemsField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Subtotal", typeof(SubtotalType))]
	[XmlElement("Grouping", typeof(GroupingType))]
	[XmlAnyElement]
	[XmlElement("ReportItems", typeof(ReportItemsType))]
	[XmlElement("Visibility", typeof(VisibilityType))]
	[XmlElement("Sorting", typeof(SortingType))]
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
