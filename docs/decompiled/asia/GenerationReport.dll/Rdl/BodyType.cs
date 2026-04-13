using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DesignerCategory("code")]
[GeneratedCode("xsd", "2.0.50727.42")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
public class BodyType
{
	private object[] itemsField;

	private ItemsChoiceType30[] itemsElementNameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("ReportItems", typeof(ReportItemsType))]
	[XmlElement("ColumnSpacing", typeof(string), DataType = "normalizedString")]
	[XmlAnyElement]
	[XmlElement("Style", typeof(StyleType))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("Height", typeof(string))]
	[XmlElement("Columns", typeof(uint))]
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
	public ItemsChoiceType30[] ItemsElementName
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
