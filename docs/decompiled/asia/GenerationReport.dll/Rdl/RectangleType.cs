using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("xsd", "2.0.50727.42")]
[DesignerCategory("code")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
public class RectangleType
{
	private object[] itemsField;

	private ItemsChoiceType12[] itemsElementNameField;

	private string nameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Left", typeof(string), DataType = "normalizedString")]
	[XmlElement("PageBreakAtStart", typeof(bool))]
	[XmlElement("RepeatWith", typeof(string))]
	[XmlElement("ReportItems", typeof(ReportItemsType))]
	[XmlElement("Style", typeof(StyleType))]
	[XmlElement("ToolTip", typeof(string))]
	[XmlElement("Top", typeof(string), DataType = "normalizedString")]
	[XmlElement("Visibility", typeof(VisibilityType))]
	[XmlElement("Width", typeof(string), DataType = "normalizedString")]
	[XmlElement("ZIndex", typeof(uint))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("LinkToChild", typeof(string))]
	[XmlAnyElement]
	[XmlElement("Action", typeof(ActionType))]
	[XmlElement("Bookmark", typeof(string))]
	[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
	[XmlElement("DataElementName", typeof(string))]
	[XmlElement("DataElementOutput", typeof(RectangleTypeDataElementOutput))]
	[XmlElement("Height", typeof(string))]
	[XmlElement("PageBreakAtEnd", typeof(bool))]
	[XmlElement("Label", typeof(string))]
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
	public ItemsChoiceType12[] ItemsElementName
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
