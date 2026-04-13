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
public class CustomDataType
{
	private object[] itemsField;

	private XmlAttribute[] anyAttrField;

	[XmlAnyElement]
	[XmlElement("DataSetName", typeof(string))]
	[XmlElement("Filters", typeof(FiltersType))]
	[XmlElement("DataColumnGroupings", typeof(DataColumnGroupingsType))]
	[XmlElement("DataRowGroupings", typeof(DataRowGroupingsType))]
	[XmlElement("DataRows", typeof(DataRowsType))]
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
