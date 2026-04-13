using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("xsd", "2.0.50727.42")]
[DesignerCategory("code")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
public class ThreeDPropertiesType
{
	private object[] itemsField;

	private ItemsChoiceType26[] itemsElementNameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Perspective", typeof(uint))]
	[XmlElement("HeightRatio", typeof(uint))]
	[XmlElement("Inclination", typeof(string), DataType = "integer")]
	[XmlElement("GapDepth", typeof(uint))]
	[XmlElement("Shading", typeof(ThreeDPropertiesTypeShading))]
	[XmlElement("ProjectionMode", typeof(ThreeDPropertiesTypeProjectionMode))]
	[XmlElement("WallThickness", typeof(uint))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("Rotation", typeof(string), DataType = "integer")]
	[XmlAnyElement]
	[XmlElement("Clustered", typeof(bool))]
	[XmlElement("DepthRatio", typeof(uint))]
	[XmlElement("DrawingStyle", typeof(ThreeDPropertiesTypeDrawingStyle))]
	[XmlElement("Enabled", typeof(bool))]
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
	public ItemsChoiceType26[] ItemsElementName
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
