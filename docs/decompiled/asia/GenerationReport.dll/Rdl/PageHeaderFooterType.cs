using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[GeneratedCode("xsd", "2.0.50727.42")]
public class PageHeaderFooterType
{
	private object[] itemsField;

	private ItemsChoiceType34[] itemsElementNameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Height", typeof(string))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlAnyElement]
	[XmlElement("PrintOnFirstPage", typeof(bool))]
	[XmlElement("PrintOnLastPage", typeof(bool))]
	[XmlElement("ReportItems", typeof(ReportItemsType))]
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
	public ItemsChoiceType34[] ItemsElementName
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
