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
public class StaticRowsType
{
	private StaticRowType[] staticRowField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("StaticRow")]
	public StaticRowType[] StaticRow
	{
		get
		{
			return staticRowField;
		}
		set
		{
			staticRowField = value;
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
