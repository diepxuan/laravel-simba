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
public class TextboxType
{
	private object[] itemsField;

	private ItemsChoiceType14[] itemsElementNameField;

	private string nameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("HideDuplicates", typeof(string))]
	[XmlElement("Label", typeof(string))]
	[XmlElement("ZIndex", typeof(uint))]
	[XmlElement("Action", typeof(ActionType))]
	[XmlElement("Bookmark", typeof(string))]
	[XmlElement("CanGrow", typeof(bool))]
	[XmlElement("CanShrink", typeof(bool))]
	[XmlAnyElement]
	[XmlElement("DataElementName", typeof(string))]
	[XmlElement("DataElementOutput", typeof(TextboxTypeDataElementOutput))]
	[XmlElement("DataElementStyle", typeof(TextboxTypeDataElementStyle))]
	[XmlElement("Height", typeof(string))]
	[XmlElement("Left", typeof(string), DataType = "normalizedString")]
	[XmlElement("LinkToChild", typeof(string))]
	[XmlElement("RepeatWith", typeof(string))]
	[XmlElement("Style", typeof(StyleType))]
	[XmlElement("ToggleImage", typeof(ToggleImageType))]
	[XmlElement("ToolTip", typeof(string))]
	[XmlElement("Top", typeof(string), DataType = "normalizedString")]
	[XmlElement("UserSort", typeof(UserSortType))]
	[XmlElement("Value", typeof(string))]
	[XmlElement("Visibility", typeof(VisibilityType))]
	[XmlElement("Width", typeof(string), DataType = "normalizedString")]
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
	public ItemsChoiceType14[] ItemsElementName
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
