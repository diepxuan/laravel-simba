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
public class AxisType
{
	private object[] itemsField;

	private ItemsChoiceType25[] itemsElementNameField;

	private XmlAttribute[] anyAttrField;

	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("MajorTickMarks", typeof(AxisTypeMajorTickMarks))]
	[XmlElement("MajorGridLines", typeof(MajorGridLinesType))]
	[XmlElement("MajorInterval", typeof(string))]
	[XmlElement("Margin", typeof(bool))]
	[XmlElement("Interlaced", typeof(bool))]
	[XmlElement("CrossAt", typeof(string))]
	[XmlElement("LogScale", typeof(bool))]
	[XmlAnyElement]
	[XmlElement("Max", typeof(string))]
	[XmlElement("Min", typeof(string))]
	[XmlElement("MinorGridLines", typeof(MinorGridLinesType))]
	[XmlElement("MinorInterval", typeof(string))]
	[XmlElement("MinorTickMarks", typeof(AxisTypeMinorTickMarks))]
	[XmlElement("Reverse", typeof(bool))]
	[XmlElement("Scalar", typeof(bool))]
	[XmlElement("Style", typeof(StyleType))]
	[XmlElement("Title", typeof(TitleType))]
	[XmlElement("Visible", typeof(bool))]
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
	public ItemsChoiceType25[] ItemsElementName
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
