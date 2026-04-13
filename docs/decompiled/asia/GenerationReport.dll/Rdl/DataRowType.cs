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
[DebuggerStepThrough]
[GeneratedCode("xsd", "2.0.50727.42")]
public class DataRowType
{
	private DataCellType[] dataCellField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("DataCell")]
	public DataCellType[] DataCell
	{
		get
		{
			return dataCellField;
		}
		set
		{
			dataCellField = value;
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
