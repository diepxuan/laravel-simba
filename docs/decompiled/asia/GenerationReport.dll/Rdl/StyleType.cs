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
[DesignerCategory("code")]
[GeneratedCode("xsd", "2.0.50727.42")]
public class StyleType
{
	private object[] itemsField;

	private ItemsChoiceType5[] itemsElementNameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Language", typeof(string))]
	[XmlElement("PaddingLeft", typeof(string))]
	[XmlElement("Color", typeof(string))]
	[XmlAnyElement]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("UnicodeBiDi", typeof(string))]
	[XmlElement("VerticalAlign", typeof(string))]
	[XmlElement("WritingMode", typeof(string))]
	[XmlElement("BackgroundColor", typeof(string))]
	[XmlElement("BackgroundGradientEndColor", typeof(string))]
	[XmlElement("BackgroundGradientType", typeof(string))]
	[XmlElement("BackgroundImage", typeof(BackgroundImageType))]
	[XmlElement("Direction", typeof(string))]
	[XmlElement("FontFamily", typeof(string))]
	[XmlElement("FontSize", typeof(string))]
	[XmlElement("FontStyle", typeof(string))]
	[XmlElement("FontWeight", typeof(string))]
	[XmlElement("NumeralLanguage", typeof(string))]
	[XmlElement("Calendar", typeof(string))]
	[XmlElement("NumeralVariant", typeof(string))]
	[XmlElement("PaddingBottom", typeof(string))]
	[XmlElement("LineHeight", typeof(string))]
	[XmlElement("PaddingRight", typeof(string))]
	[XmlElement("PaddingTop", typeof(string))]
	[XmlElement("TextAlign", typeof(string))]
	[XmlElement("TextDecoration", typeof(string))]
	[XmlElement("BorderStyle", typeof(BorderColorStyleWidthType))]
	[XmlElement("BorderWidth", typeof(BorderColorStyleWidthType))]
	[XmlElement("Format", typeof(string))]
	[XmlElement("BorderColor", typeof(BorderColorStyleWidthType))]
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
	public ItemsChoiceType5[] ItemsElementName
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
