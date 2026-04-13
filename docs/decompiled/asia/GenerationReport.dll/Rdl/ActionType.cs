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
public class ActionType
{
	private object[] itemsField;

	private ItemsChoiceType8[] itemsElementNameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("BookmarkLink", typeof(string))]
	[XmlElement("Hyperlink", typeof(string))]
	[XmlElement("Drillthrough", typeof(DrillthroughType))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("Label", typeof(string))]
	[XmlAnyElement]
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
	public ItemsChoiceType8[] ItemsElementName
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
