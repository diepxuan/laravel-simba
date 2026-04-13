using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[DesignerCategory("code")]
[GeneratedCode("xsd", "2.0.50727.42")]
[DebuggerStepThrough]
public class DataPointType
{
	private object[] itemsField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Marker", typeof(MarkerType))]
	[XmlElement("DataElementOutput", typeof(DataPointTypeDataElementOutput))]
	[XmlAnyElement]
	[XmlElement("Action", typeof(ActionType))]
	[XmlElement("DataElementName", typeof(string))]
	[XmlElement("DataValues", typeof(DataValuesType))]
	[XmlElement("Style", typeof(StyleType))]
	[XmlElement("DataLabel", typeof(DataLabelType))]
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
