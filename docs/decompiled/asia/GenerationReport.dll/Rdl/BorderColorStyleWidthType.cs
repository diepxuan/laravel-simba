using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[GeneratedCode("xsd", "2.0.50727.42")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class BorderColorStyleWidthType
{
	private object[] itemsField;

	private ItemsChoiceType3[] itemsElementNameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Right", typeof(string))]
	[XmlElement("Default", typeof(string))]
	[XmlAnyElement]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("Bottom", typeof(string))]
	[XmlElement("Top", typeof(string))]
	[XmlElement("Left", typeof(string))]
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
	public ItemsChoiceType3[] ItemsElementName
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
