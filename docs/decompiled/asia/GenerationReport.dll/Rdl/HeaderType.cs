using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DebuggerStepThrough]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[GeneratedCode("xsd", "2.0.50727.42")]
[DesignerCategory("code")]
public class HeaderType
{
	private object[] itemsField;

	private ItemsChoiceType20[] itemsElementNameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("RepeatOnNewPage", typeof(bool))]
	[XmlAnyElement]
	[XmlElement("TableRows", typeof(TableRowsType))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("FixedHeader", typeof(bool))]
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
	public ItemsChoiceType20[] ItemsElementName
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
