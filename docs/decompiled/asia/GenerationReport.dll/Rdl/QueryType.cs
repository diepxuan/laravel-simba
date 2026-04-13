using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DesignerCategory("code")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[GeneratedCode("xsd", "2.0.50727.42")]
[DebuggerStepThrough]
public class QueryType
{
	private object[] itemsField;

	private ItemsChoiceType2[] itemsElementNameField;

	private XmlAttribute[] anyAttrField;

	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("Timeout", typeof(uint))]
	[XmlAnyElement]
	[XmlElement("CommandText", typeof(string))]
	[XmlElement("DataSourceName", typeof(string))]
	[XmlElement("QueryParameters", typeof(QueryParametersType))]
	[XmlElement("CommandType", typeof(QueryTypeCommandType))]
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
	public ItemsChoiceType2[] ItemsElementName
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
