using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("xsd", "2.0.50727.42")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
public class ColumnGroupingType
{
	private object[] itemsField;

	private XmlAttribute[] anyAttrField;

	[XmlAnyElement]
	[XmlElement("FixedHeader", typeof(bool))]
	[XmlElement("StaticColumns", typeof(StaticColumnsType))]
	[XmlElement("Height", typeof(string))]
	[XmlElement("DynamicColumns", typeof(DynamicColumnsRowsType))]
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
