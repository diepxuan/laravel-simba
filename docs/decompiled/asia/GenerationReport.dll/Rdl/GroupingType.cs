using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DesignerCategory("code")]
[GeneratedCode("xsd", "2.0.50727.42")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
public class GroupingType
{
	private object[] itemsField;

	private ItemsChoiceType17[] itemsElementNameField;

	private string nameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Filters", typeof(FiltersType))]
	[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
	[XmlAnyElement]
	[XmlElement("Label", typeof(string))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("GroupExpressions", typeof(GroupExpressionsType))]
	[XmlElement("DataCollectionName", typeof(string))]
	[XmlElement("DataElementName", typeof(string))]
	[XmlElement("PageBreakAtEnd", typeof(bool))]
	[XmlElement("PageBreakAtStart", typeof(bool))]
	[XmlElement("Parent", typeof(string))]
	[XmlElement("DataElementOutput", typeof(GroupingTypeDataElementOutput))]
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

	[XmlElement("ItemsElementName")]
	[XmlIgnore]
	public ItemsChoiceType17[] ItemsElementName
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

	[XmlAttribute(DataType = "normalizedString")]
	public string Name
	{
		get
		{
			return nameField;
		}
		set
		{
			nameField = value;
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
