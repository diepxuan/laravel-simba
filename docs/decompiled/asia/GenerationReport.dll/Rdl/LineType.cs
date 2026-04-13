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
public class LineType
{
	private object[] itemsField;

	private ItemsChoiceType11[] itemsElementNameField;

	private string nameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("DataElementOutput", typeof(LineTypeDataElementOutput))]
	[XmlElement("ZIndex", typeof(uint))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("Left", typeof(string), DataType = "normalizedString")]
	[XmlElement("Width", typeof(string), DataType = "normalizedString")]
	[XmlElement("Action", typeof(ActionType))]
	[XmlElement("Bookmark", typeof(string))]
	[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
	[XmlElement("DataElementName", typeof(string))]
	[XmlElement("Height", typeof(string))]
	[XmlElement("Label", typeof(string))]
	[XmlAnyElement]
	[XmlElement("LinkToChild", typeof(string))]
	[XmlElement("RepeatWith", typeof(string))]
	[XmlElement("Style", typeof(StyleType))]
	[XmlElement("ToolTip", typeof(string))]
	[XmlElement("Top", typeof(string), DataType = "normalizedString")]
	[XmlElement("Visibility", typeof(VisibilityType))]
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
	public ItemsChoiceType11[] ItemsElementName
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
