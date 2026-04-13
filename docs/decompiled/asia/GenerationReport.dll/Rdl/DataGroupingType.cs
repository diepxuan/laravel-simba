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
[DesignerCategory("code")]
[DebuggerStepThrough]
public class DataGroupingType
{
	private object[] itemsField;

	private ItemsChoiceType28[] itemsElementNameField;

	private XmlAttribute[] anyAttrField;

	[XmlAnyElement]
	[XmlElement("Grouping", typeof(GroupingType))]
	[XmlElement("Sorting", typeof(SortingType))]
	[XmlElement("Static", typeof(bool))]
	[XmlElement("DataGroupings", typeof(DataGroupingsType))]
	[XmlElement("Subtotal", typeof(bool))]
	[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
	[XmlChoiceIdentifier("ItemsElementName")]
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

	[XmlIgnore]
	[XmlElement("ItemsElementName")]
	public ItemsChoiceType28[] ItemsElementName
	{
		get
		{
			return itemsElementNameField;
		}
		set
		{
			itemsElementNameField = value;
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
