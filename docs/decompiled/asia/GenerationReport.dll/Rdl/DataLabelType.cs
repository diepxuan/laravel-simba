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
public class DataLabelType
{
	private object[] itemsField;

	private ItemsChoiceType23[] itemsElementNameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Visible", typeof(bool))]
	[XmlAnyElement]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("Value", typeof(string))]
	[XmlElement("Position", typeof(DataLabelTypePosition))]
	[XmlElement("Rotation", typeof(string), DataType = "integer")]
	[XmlElement("Style", typeof(StyleType))]
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
	public ItemsChoiceType23[] ItemsElementName
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
