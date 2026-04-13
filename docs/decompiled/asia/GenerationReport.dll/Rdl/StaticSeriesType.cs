using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[GeneratedCode("xsd", "2.0.50727.42")]
public class StaticSeriesType
{
	private StaticMemberType[] staticMemberField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("StaticMember")]
	public StaticMemberType[] StaticMember
	{
		get
		{
			return staticMemberField;
		}
		set
		{
			staticMemberField = value;
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
