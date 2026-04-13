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
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[DebuggerStepThrough]
public class ListType
{
	private object[] itemsField;

	private ItemsChoiceType18[] itemsElementNameField;

	private string nameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Grouping", typeof(GroupingType))]
	[XmlElement("KeepTogether", typeof(bool))]
	[XmlElement("Left", typeof(string), DataType = "normalizedString")]
	[XmlElement("LinkToChild", typeof(string))]
	[XmlElement("NoRows", typeof(string))]
	[XmlElement("PageBreakAtEnd", typeof(bool))]
	[XmlElement("PageBreakAtStart", typeof(bool))]
	[XmlElement("RepeatWith", typeof(string))]
	[XmlElement("ReportItems", typeof(ReportItemsType))]
	[XmlElement("Sorting", typeof(SortingType))]
	[XmlElement("Style", typeof(StyleType))]
	[XmlElement("ToolTip", typeof(string))]
	[XmlElement("Top", typeof(string), DataType = "normalizedString")]
	[XmlElement("Visibility", typeof(VisibilityType))]
	[XmlElement("Width", typeof(string), DataType = "normalizedString")]
	[XmlElement("ZIndex", typeof(uint))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("Label", typeof(string))]
	[XmlAnyElement]
	[XmlElement("Action", typeof(ActionType))]
	[XmlElement("Bookmark", typeof(string))]
	[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
	[XmlElement("DataElementName", typeof(string))]
	[XmlElement("DataElementOutput", typeof(ListTypeDataElementOutput))]
	[XmlElement("DataInstanceElementOutput", typeof(ListTypeDataInstanceElementOutput))]
	[XmlElement("DataInstanceName", typeof(string))]
	[XmlElement("DataSetName", typeof(string))]
	[XmlElement("FillPage", typeof(bool))]
	[XmlElement("Filters", typeof(FiltersType))]
	[XmlElement("Height", typeof(string))]
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
	public ItemsChoiceType18[] ItemsElementName
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
