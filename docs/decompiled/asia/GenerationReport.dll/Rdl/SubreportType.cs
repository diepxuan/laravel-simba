using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DesignerCategory("code")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[DebuggerStepThrough]
[GeneratedCode("xsd", "2.0.50727.42")]
public class SubreportType
{
	private object[] itemsField;

	private ItemsChoiceType16[] itemsElementNameField;

	private string nameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Parameters", typeof(ParametersType))]
	[XmlElement("Label", typeof(string))]
	[XmlElement("Left", typeof(string), DataType = "normalizedString")]
	[XmlElement("LinkToChild", typeof(string))]
	[XmlElement("MergeTransactions", typeof(bool))]
	[XmlElement("NoRows", typeof(string))]
	[XmlAnyElement]
	[XmlElement("RepeatWith", typeof(string))]
	[XmlElement("ReportName", typeof(string))]
	[XmlElement("Style", typeof(StyleType))]
	[XmlElement("ToolTip", typeof(string))]
	[XmlElement("Top", typeof(string), DataType = "normalizedString")]
	[XmlElement("Visibility", typeof(VisibilityType))]
	[XmlElement("Width", typeof(string), DataType = "normalizedString")]
	[XmlElement("ZIndex", typeof(uint))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("Action", typeof(ActionType))]
	[XmlElement("Bookmark", typeof(string))]
	[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
	[XmlElement("DataElementName", typeof(string))]
	[XmlElement("DataElementOutput", typeof(SubreportTypeDataElementOutput))]
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
	public ItemsChoiceType16[] ItemsElementName
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
