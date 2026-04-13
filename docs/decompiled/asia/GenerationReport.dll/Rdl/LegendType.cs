using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[GeneratedCode("xsd", "2.0.50727.42")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class LegendType
{
	private object[] itemsField;

	private ItemsChoiceType24[] itemsElementNameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Position", typeof(LegendTypePosition))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlAnyElement]
	[XmlElement("Style", typeof(StyleType))]
	[XmlElement("Visible", typeof(bool))]
	[XmlElement("InsidePlotArea", typeof(bool))]
	[XmlElement("Layout", typeof(LegendTypeLayout))]
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
	public ItemsChoiceType24[] ItemsElementName
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
