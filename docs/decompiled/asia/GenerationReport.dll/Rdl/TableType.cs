using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[GeneratedCode("xsd", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
public class TableType
{
	private object[] itemsField;

	private ItemsChoiceType21[] itemsElementNameField;

	private string nameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Left", typeof(string), DataType = "normalizedString")]
	[XmlElement("Width", typeof(string), DataType = "normalizedString")]
	[XmlElement("Visibility", typeof(VisibilityType))]
	[XmlElement("Header", typeof(HeaderType))]
	[XmlElement("Top", typeof(string), DataType = "normalizedString")]
	[XmlElement("DetailDataElementOutput", typeof(TableTypeDetailDataElementOutput))]
	[XmlElement("Details", typeof(DetailsType))]
	[XmlElement("Bookmark", typeof(string))]
	[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
	[XmlElement("DataElementName", typeof(string))]
	[XmlElement("DataElementOutput", typeof(TableTypeDataElementOutput))]
	[XmlAnyElement]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("DataSetName", typeof(string))]
	[XmlElement("FillPage", typeof(bool))]
	[XmlElement("Filters", typeof(FiltersType))]
	[XmlElement("ZIndex", typeof(uint))]
	[XmlElement("Footer", typeof(FooterType))]
	[XmlElement("Action", typeof(ActionType))]
	[XmlElement("Height", typeof(string))]
	[XmlElement("KeepTogether", typeof(bool))]
	[XmlElement("Label", typeof(string))]
	[XmlElement("ToolTip", typeof(string))]
	[XmlElement("LinkToChild", typeof(string))]
	[XmlElement("NoRows", typeof(string))]
	[XmlElement("PageBreakAtEnd", typeof(bool))]
	[XmlElement("PageBreakAtStart", typeof(bool))]
	[XmlElement("RepeatWith", typeof(string))]
	[XmlElement("DetailDataCollectionName", typeof(string))]
	[XmlElement("DetailDataElementName", typeof(string))]
	[XmlElement("Style", typeof(StyleType))]
	[XmlElement("TableColumns", typeof(TableColumnsType))]
	[XmlElement("TableGroups", typeof(TableGroupsType))]
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
	public ItemsChoiceType21[] ItemsElementName
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
