using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[GeneratedCode("xsd", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
public class RowGroupingsType
{
	private RowGroupingType[] rowGroupingField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("RowGrouping")]
	public RowGroupingType[] RowGrouping
	{
		get
		{
			return rowGroupingField;
		}
		set
		{
			rowGroupingField = value;
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
