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
[DesignerCategory("code")]
[DebuggerStepThrough]
public class BackgroundImageType
{
	private object[] itemsField;

	private ItemsChoiceType4[] itemsElementNameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("MIMEType", typeof(string))]
	[XmlAnyElement]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("Value", typeof(string))]
	[XmlElement("Source", typeof(BackgroundImageTypeSource))]
	[XmlElement("BackgroundRepeat", typeof(string))]
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
	public ItemsChoiceType4[] ItemsElementName
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
