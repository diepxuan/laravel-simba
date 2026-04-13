using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[GeneratedCode("xsd", "2.0.50727.42")]
public class CustomReportItemType
{
	private object[] itemsField;

	private ItemsChoiceType29[] itemsElementNameField;

	private string nameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Label", typeof(string))]
	[XmlElement("DataElementOutput", typeof(CustomReportItemTypeDataElementOutput))]
	[XmlElement("Height", typeof(string))]
	[XmlElement("Top", typeof(string), DataType = "normalizedString")]
	[XmlElement("Type", typeof(string))]
	[XmlElement("Visibility", typeof(VisibilityType))]
	[XmlElement("Width", typeof(string), DataType = "normalizedString")]
	[XmlElement("ZIndex", typeof(uint))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("Bookmark", typeof(string))]
	[XmlElement("AltReportItem", typeof(ReportItemsType))]
	[XmlElement("Left", typeof(string), DataType = "normalizedString")]
	[XmlElement("RepeatWith", typeof(string))]
	[XmlElement("Style", typeof(StyleType))]
	[XmlAnyElement]
	[XmlElement("DataElementName", typeof(string))]
	[XmlElement("CustomData", typeof(CustomDataType))]
	[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
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
	public ItemsChoiceType29[] ItemsElementName
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
