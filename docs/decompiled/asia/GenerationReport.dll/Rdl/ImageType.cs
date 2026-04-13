using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[GeneratedCode("xsd", "2.0.50727.42")]
[DesignerCategory("code")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[DebuggerStepThrough]
public class ImageType
{
	private object[] itemsField;

	private ItemsChoiceType15[] itemsElementNameField;

	private string nameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Top", typeof(string), DataType = "normalizedString")]
	[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
	[XmlElement("ToolTip", typeof(string))]
	[XmlElement("Value", typeof(string))]
	[XmlElement("DataElementName", typeof(string))]
	[XmlElement("Style", typeof(StyleType))]
	[XmlElement("Width", typeof(string), DataType = "normalizedString")]
	[XmlElement("ZIndex", typeof(uint))]
	[XmlElement("Visibility", typeof(VisibilityType))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlAnyElement]
	[XmlElement("Action", typeof(ActionType))]
	[XmlElement("Bookmark", typeof(string))]
	[XmlElement("DataElementOutput", typeof(ImageTypeDataElementOutput))]
	[XmlElement("Height", typeof(string))]
	[XmlElement("Label", typeof(string))]
	[XmlElement("Left", typeof(string), DataType = "normalizedString")]
	[XmlElement("LinkToChild", typeof(string))]
	[XmlElement("MIMEType", typeof(string))]
	[XmlElement("RepeatWith", typeof(string))]
	[XmlElement("Sizing", typeof(ImageTypeSizing))]
	[XmlElement("Source", typeof(ImageTypeSource))]
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
	public ItemsChoiceType15[] ItemsElementName
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
